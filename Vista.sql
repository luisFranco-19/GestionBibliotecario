USE BibliotecaDB
GO
--Mostrar el detalle de los prestamos del usuario

CREATE OR ALTER VIEW vw_detallePrestamo
AS
SELECT 
    dp.idDetallePrestamo AS IdDetalle,
     dp.idLibro AS IdLibro,
    u.carnet AS Carnet,
    u.nombre + ' ' + u.apellido AS NombreUsuario,
    u.cargo AS Cargo,
    l.titulo AS TituloLibro,
    dp.cantidad AS Cantidad,
    p.fechaPrestamo AS FechaPrestamo,
    dp.fechaDevolucion AS FechaDevolucion,
    dp.estado AS Estado
FROM 
    DetallePrestamos dp
    INNER JOIN Prestamos p ON dp.idPrestamo = p.idPrestamo
    INNER JOIN Usuarios u ON p.idUsuario = u.idUsuario
    INNER JOIN Libros l ON dp.idLibro = l.idLibro;
GO;



SELECT *
FROM vw_detallePrestamo
ORDER BY 
    CASE Estado 
        WHEN 'Prestado' THEN 1
        WHEN 'Devuelto' THEN 2
        ELSE 3
    END,
    FechaPrestamo DESC;
GO;
-- Mostrar el historial de libros no devueltos por el usuario o que estan 
-- en prestamo 

CREATE OR ALTER VIEW vw_LibrosPrestados 
AS
SELECT 
    P.idUsuario,
    D.idDetallePrestamo,
    D.idLibro,
    L.titulo,
    A.nombre AS autor, 
    D.cantidad,
    D.fechaDevolucion,
    D.estado,
    P.fechaPrestamo
FROM Prestamos AS P
INNER JOIN DetallePrestamos AS D ON P.idPrestamo = D.idPrestamo
INNER JOIN Libros AS L ON D.idLibro = L.idLibro
INNER JOIN Autores AS A ON L.idAutor = A.idAutor;
GO;

SELECT * FROM vw_LibrosPrestados
GO;



-- Usuarios con mas prestamos
USE BibliotecaDB;
GO;

CREATE OR ALTER VIEW vw_Top10UsuariosPrestamos
AS
SELECT TOP 10 
    U.nombre + ' ' + U.apellido AS Usuario,
    COUNT(P.idPrestamo) AS TotalPrestamos
FROM Prestamos P
INNER JOIN Usuarios U ON U.idUsuario = P.idUsuario
GROUP BY U.nombre, U.apellido
ORDER BY TotalPrestamos DESC;
GO

SELECT * FROM vw_Top10UsuariosPrestamos
GO;

--Lisbros mas vistos
CREATE OR ALTER VIEW vw_Top10LibrosPopulares
AS
SELECT TOP 10 
    L.titulo AS Libro,
    COUNT(DP.idDetallePrestamo) AS TotalPrestamos
FROM DetallePrestamos DP
INNER JOIN Libros L ON L.idLibro = DP.idLibro
GROUP BY L.titulo
ORDER BY TotalPrestamos DESC;
GO;

SELECT * FROM vw_Top10LibrosPopulares
GO;

--cantidad de usuarios por tipo (Docente o Alumno).
CREATE OR ALTER VIEW vw_DistribucionUsuarios
AS
SELECT 
    cargo AS TipoUsuario,
    COUNT(*) AS Total
FROM Usuarios
GROUP BY cargo;
GO;

SELECT * FROM vw_DistribucionUsuarios
GO;

/*
Procedimeinto almacenado para el formulario Usuarios
*/

USE BibliotecaDB;
GO

-- ==========================================
-- PROCEDIMIENTO: Insertar Usuario
-- ==========================================
CREATE OR ALTER PROC sp_InsertarUsuario
    @Carnet VARCHAR(15),
    @Nombre VARCHAR(70),
    @Apellido VARCHAR(70),
    @Telefono VARCHAR(15),
    @Email VARCHAR(70),
    @Cargo VARCHAR(10),
    @FechaRegistro DATE
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO Usuarios (carnet, nombre, apellido, telefono, email, cargo, fechaRegistro)
        VALUES (@Carnet, @Nombre, @Apellido, @Telefono, @Email, @Cargo, @FechaRegistro);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO historialErrores(descripcion)
        VALUES (ERROR_MESSAGE());

        RAISERROR('Error al insertar usuario. Revise el historial de errores.', 16, 1);
    END CATCH
END;
GO


-- ==========================================
-- PROCEDIMIENTO: Actualizar Usuario
-- ==========================================
CREATE OR ALTER PROC sp_ActualizarUsuario
    @IdUsuario INT,
    @Carnet VARCHAR(15),
    @Nombre VARCHAR(70),
    @Apellido VARCHAR(70),
    @Telefono VARCHAR(15),
    @Email VARCHAR(70),
    @Cargo VARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE Usuarios
        SET carnet = @Carnet,
            nombre = @Nombre,
            apellido = @Apellido,
            telefono = @Telefono,
            email = @Email,
            cargo = @Cargo
        WHERE idUsuario = @IdUsuario;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO historialErrores(descripcion)
        VALUES (ERROR_MESSAGE());

        RAISERROR('Error al actualizar usuario. Revise el historial de errores.', 16, 1);
    END CATCH
END;
GO


-- ==========================================
-- PROCEDIMIENTO: Eliminar Usuario
-- ==========================================
CREATE OR ALTER PROC sp_EliminarUsuario
@IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @TienePrestamos INT;

        -- Verificar préstamos activos
        SELECT @TienePrestamos = COUNT(*) 
        FROM Prestamos P
        INNER JOIN DetallePrestamos DP ON P.idPrestamo = DP.idPrestamo
        WHERE P.idUsuario = @IdUsuario AND (DP.estado = 'Prestado' OR DP.fechaDevolucion IS NULL);

        IF @TienePrestamos > 0
        BEGIN
            RAISERROR('El usuario tiene préstamos pendientes y no puede eliminarse.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        -- Eliminar detalle de préstamos devueltos
        DELETE DP
        FROM DetallePrestamos DP
        INNER JOIN Prestamos P ON DP.idPrestamo = P.idPrestamo
        WHERE P.idUsuario = @IdUsuario AND DP.estado = 'Devuelto';

        -- Eliminar préstamos
        DELETE FROM Prestamos
        WHERE idUsuario = @IdUsuario;

        -- Eliminar usuario
        DELETE FROM Usuarios
        WHERE idUsuario = @IdUsuario;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO historialErrores(descripcion)
        VALUES (ERROR_MESSAGE());

        RAISERROR('Error al eliminar usuario. Revise el historial de errores.', 16, 1);
    END CATCH
END;
GO



/*
Procedieminto almacenado para el formulario Libros
*/

-- ==========================================
-- PROCEDIMIENTO: Insertar Libro
-- ==========================================
CREATE OR ALTER PROC sp_InsertarLibro
    @Titulo VARCHAR(100),
    @NombreAutor VARCHAR(70),
    @Nacionalidad VARCHAR(50),
    @Estado VARCHAR(10),
    @AnioPublicacion INT,
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IdAutor INT;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar si el autor ya existe
        SELECT @IdAutor = idAutor 
        FROM Autores 
        WHERE nombre = @NombreAutor AND nacionalidad = @Nacionalidad;

        -- Si no existe, se inserta (fechaRegistro se pone automáticamente)
        IF @IdAutor IS NULL
        BEGIN
            INSERT INTO Autores (nombre, nacionalidad)
            VALUES (@NombreAutor, @Nacionalidad);

            SET @IdAutor = SCOPE_IDENTITY();
        END;

        -- Insertar libro (fechaRegistro se pone automáticamente)
        INSERT INTO Libros (titulo, idAutor, estado, anioPublicacion, cantidad)
        VALUES (@Titulo, @IdAutor, @Estado, @AnioPublicacion, @Cantidad);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO historialErrores(descripcion)
        VALUES (ERROR_MESSAGE());

        RAISERROR('Error al insertar libro. Revise el historial de errores.', 16, 1);
    END CATCH
END;
GO



-- ==========================================
-- PROCEDIMIENTO: Actualizar Libro
-- ==========================================
CREATE OR ALTER PROC sp_ActualizarLibro
    @IdLibro INT,
    @Titulo VARCHAR(100),
    @NombreAutor VARCHAR(70),
    @Nacionalidad VARCHAR(50),
    @Estado VARCHAR(10),
    @AnioPublicacion INT,
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IdAutor INT;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Obtener idAutor actual del libro
        SELECT @IdAutor = idAutor 
        FROM Libros 
        WHERE idLibro = @IdLibro;

        IF @IdAutor IS NULL
        BEGIN
            RAISERROR('No se encontró el libro especificado.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        -- Actualizar datos del autor
        UPDATE Autores
        SET nombre = @NombreAutor,
            nacionalidad = @Nacionalidad
        WHERE idAutor = @IdAutor;

        -- Actualizar datos del libro
        UPDATE Libros
        SET titulo = @Titulo,
            estado = @Estado,
            anioPublicacion = @AnioPublicacion,
            cantidad = @Cantidad
        WHERE idLibro = @IdLibro;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO historialErrores(descripcion)
        VALUES (ERROR_MESSAGE());

        RAISERROR('Error al actualizar libro. Revise el historial de errores.', 16, 1);
    END CATCH
END;
GO


-- ==========================================
-- PROCEDIMIENTO: Eliminar Libro
-- ==========================================
CREATE OR ALTER PROC sp_EliminarLibro
    @IdLibro INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar préstamos activos
        IF EXISTS (SELECT 1 FROM DetallePrestamos WHERE idLibro = @IdLibro AND fechaDevolucion IS NULL)
        BEGIN
            RAISERROR('No se puede eliminar este libro porque tiene préstamos activos.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        -- Eliminar detalle de préstamos asociados
        DELETE FROM DetallePrestamos WHERE idLibro = @IdLibro;

        -- Eliminar préstamos huérfanos
        DELETE FROM Prestamos
        WHERE idPrestamo NOT IN (SELECT idPrestamo FROM DetallePrestamos);

        -- Eliminar libro
        DELETE FROM Libros WHERE idLibro = @IdLibro;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        INSERT INTO historialErrores(descripcion)
        VALUES (ERROR_MESSAGE());

        RAISERROR('Error al eliminar libro. Revise el historial de errores.', 16, 1);
    END CATCH
END;
GO


/*
Procedimiento almacenado El login
*/

USE BibliotecaDB;
GO

CREATE OR ALTER PROC sp_InsertarUsuarioLogin
    @NombreUsuario VARCHAR(50),
    @Email VARCHAR(100),
    @Password VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Verificar si ya existe usuario o email
        IF EXISTS(SELECT 1 FROM UsuarioLogin WHERE nombreUsuario=@NombreUsuario OR email=@Email)
        BEGIN
            RAISERROR('El usuario o email ya existe', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        -- Insertar usuario (fechaRegistro se llena automáticamente si la tabla tiene DEFAULT GETDATE())
        INSERT INTO UsuarioLogin (nombreUsuario, email, password, estado)
        VALUES (@NombreUsuario, @Email, @Password, 1);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        -- Guardar error en historial
        INSERT INTO historialErrores(descripcion)
        VALUES (ERROR_MESSAGE());

        RAISERROR('Error al insertar usuario login. Revise el historial de errores.', 16, 1);
    END CATCH
END;
GO

CREATE OR ALTER PROC sp_ValidarLogin
    @NombreUsuario VARCHAR(50),
    @Password VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @IdUsuario INT = 0;

    BEGIN TRY
        SELECT @IdUsuario = idUsuarioLogin
        FROM UsuarioLogin
        WHERE nombreUsuario = @NombreUsuario COLLATE Latin1_General_CS_AS
          AND password = @Password
          AND estado = 1;

        SELECT @IdUsuario AS IdUsuarioLogin;
    END TRY
    BEGIN CATCH
        -- Guardar error en historial
        INSERT INTO historialErrores(descripcion)
        VALUES (ERROR_MESSAGE());

        RAISERROR('Error al validar login. Revise el historial de errores.', 16, 1);
    END CATCH
END;
GO

