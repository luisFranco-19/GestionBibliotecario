-- Ejecutar después de BibliotecaDB.sql, seleccionando el archivo completo.
-- SQL Server 2016 SP1 o posterior. Puede volver a ejecutarse.
USE [BibliotecaDB];
GO
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

CREATE OR ALTER VIEW dbo.vw_detallePrestamo
AS
SELECT dp.idDetallePrestamo AS IdDetalle,
       dp.idLibro AS IdLibro,
       u.carnet AS Carnet,
       u.nombre + ' ' + u.apellido AS NombreUsuario,
       u.cargo AS Cargo,
       l.titulo AS TituloLibro,
       dp.cantidad AS Cantidad,
       p.fechaPrestamo AS FechaPrestamo,
       dp.fechaDevolucion AS FechaDevolucion,
       dp.estado AS Estado
FROM dbo.DetallePrestamos AS dp
JOIN dbo.Prestamos AS p ON dp.idPrestamo = p.idPrestamo
JOIN dbo.Usuarios AS u ON p.idUsuario = u.idUsuario
JOIN dbo.Libros AS l ON dp.idLibro = l.idLibro;
GO

-- Mantener el historial completo: el formulario filtra estado = 'Prestado'.
CREATE OR ALTER VIEW dbo.vw_LibrosPrestados
AS
SELECT p.idUsuario,
       d.idDetallePrestamo,
       d.idLibro,
       l.titulo,
       a.nombre AS autor,
       d.cantidad,
       d.fechaDevolucion,
       d.estado,
       p.fechaPrestamo
FROM dbo.Prestamos AS p
JOIN dbo.DetallePrestamos AS d ON p.idPrestamo = d.idPrestamo
JOIN dbo.Libros AS l ON d.idLibro = l.idLibro
JOIN dbo.Autores AS a ON l.idAutor = a.idAutor;
GO

-- Agrupar por identificador para no mezclar usuarios con el mismo nombre.
-- Para presentar un orden específico, agregar ORDER BY al SELECT que consulta la vista.
CREATE OR ALTER VIEW dbo.vw_Top10UsuariosPrestamos
AS
SELECT TOP (10) u.nombre + ' ' + u.apellido AS Usuario,
       COUNT(p.idPrestamo) AS TotalPrestamos
FROM dbo.Prestamos AS p
JOIN dbo.Usuarios AS u ON u.idUsuario = p.idUsuario
GROUP BY u.idUsuario, u.nombre, u.apellido
ORDER BY COUNT(p.idPrestamo) DESC, u.idUsuario ASC;
GO

-- Dos libros con el mismo título siguen siendo registros diferentes.
CREATE OR ALTER VIEW dbo.vw_Top10LibrosPopulares
AS
SELECT TOP (10) l.titulo AS Libro,
       COUNT(dp.idDetallePrestamo) AS TotalPrestamos
FROM dbo.DetallePrestamos AS dp
JOIN dbo.Libros AS l ON l.idLibro = dp.idLibro
GROUP BY l.idLibro, l.titulo
ORDER BY COUNT(dp.idDetallePrestamo) DESC, l.idLibro ASC;
GO

CREATE OR ALTER VIEW dbo.vw_DistribucionUsuarios
AS
SELECT cargo AS TipoUsuario, COUNT(*) AS Total
FROM dbo.Usuarios
GROUP BY cargo;
GO

-- NOCOUNT OFF en estos dos procedimientos: FrmUsuarios usa ExecuteNonQuery() > 0.
CREATE OR ALTER PROC dbo.sp_InsertarUsuario
    @Carnet VARCHAR(15),
    @Nombre VARCHAR(70),
    @Apellido VARCHAR(70),
    @Telefono VARCHAR(15),
    @Email VARCHAR(70),
    @Cargo VARCHAR(10),
    @FechaRegistro DATE
AS
BEGIN
    SET NOCOUNT OFF;
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        INSERT INTO dbo.Usuarios (carnet, nombre, apellido, telefono, email, cargo, fechaRegistro)
        VALUES (@Carnet, @Nombre, @Apellido, @Telefono, @Email, @Cargo, COALESCE(@FechaRegistro, CONVERT(DATE, GETDATE())));
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @Error NVARCHAR(2048) = ERROR_MESSAGE();
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SET NOCOUNT ON;
        INSERT INTO dbo.historialErrores (descripcion) VALUES (LEFT(@Error, 255));
        RAISERROR(N'Error al insertar usuario: %s', 16, 1, @Error);
    END CATCH;
END;
GO

CREATE OR ALTER PROC dbo.sp_ActualizarUsuario
    @IdUsuario INT,
    @Carnet VARCHAR(15),
    @Nombre VARCHAR(70),
    @Apellido VARCHAR(70),
    @Telefono VARCHAR(15),
    @Email VARCHAR(70),
    @Cargo VARCHAR(10)
AS
BEGIN
    SET NOCOUNT OFF;
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        UPDATE dbo.Usuarios
        SET carnet = @Carnet, nombre = @Nombre, apellido = @Apellido,
            telefono = @Telefono, email = @Email, cargo = @Cargo
        WHERE idUsuario = @IdUsuario;

        IF @@ROWCOUNT = 0
            THROW 50010, N'No se encontró el usuario especificado.', 1;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @Error NVARCHAR(2048) = ERROR_MESSAGE();
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SET NOCOUNT ON;
        INSERT INTO dbo.historialErrores (descripcion) VALUES (LEFT(@Error, 255));
        RAISERROR(N'Error al actualizar usuario: %s', 16, 1, @Error);
    END CATCH;
END;
GO

CREATE OR ALTER PROC dbo.sp_EliminarUsuario
    @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        IF NOT EXISTS (SELECT 1 FROM dbo.Usuarios WITH (UPDLOCK, HOLDLOCK) WHERE idUsuario = @IdUsuario)
            THROW 50011, N'No se encontró el usuario especificado.', 1;

        IF EXISTS (
            SELECT 1
            FROM dbo.Prestamos AS p WITH (UPDLOCK, HOLDLOCK)
            JOIN dbo.DetallePrestamos AS dp WITH (UPDLOCK, HOLDLOCK) ON p.idPrestamo = dp.idPrestamo
            WHERE p.idUsuario = @IdUsuario AND (dp.estado IS NULL OR dp.estado <> 'Devuelto')
        )
            THROW 50012, N'El usuario tiene préstamos pendientes y no puede eliminarse.', 1;

        DELETE dp
        FROM dbo.DetallePrestamos AS dp
        JOIN dbo.Prestamos AS p ON p.idPrestamo = dp.idPrestamo
        WHERE p.idUsuario = @IdUsuario;

        DELETE FROM dbo.Prestamos WHERE idUsuario = @IdUsuario;
        DELETE FROM dbo.Usuarios WHERE idUsuario = @IdUsuario;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @Error NVARCHAR(2048) = ERROR_MESSAGE();
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SET NOCOUNT ON;
        INSERT INTO dbo.historialErrores (descripcion) VALUES (LEFT(@Error, 255));
        RAISERROR(N'Error al eliminar usuario: %s', 16, 1, @Error);
    END CATCH;
END;
GO

CREATE OR ALTER PROC dbo.sp_InsertarLibro
    @Titulo VARCHAR(100),
    @NombreAutor VARCHAR(70),
    @Nacionalidad VARCHAR(50),
    @Estado VARCHAR(10),
    @AnioPublicacion INT,
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        IF @Cantidad IS NULL OR @Cantidad < 0
            THROW 50020, N'La cantidad de libros no puede ser negativa ni nula.', 1;

        DECLARE @IdAutor INT;
        SELECT TOP (1) @IdAutor = idAutor
        FROM dbo.Autores WITH (UPDLOCK, HOLDLOCK)
        WHERE nombre = @NombreAutor
          AND (nacionalidad = @Nacionalidad OR (nacionalidad IS NULL AND @Nacionalidad IS NULL))
        ORDER BY idAutor;

        IF @IdAutor IS NULL
        BEGIN
            INSERT INTO dbo.Autores (nombre, nacionalidad)
            VALUES (@NombreAutor, @Nacionalidad);
            SET @IdAutor = CONVERT(INT, SCOPE_IDENTITY());
        END;

        INSERT INTO dbo.Libros (titulo, idAutor, estado, anioPublicacion, cantidad)
        VALUES (@Titulo, @IdAutor, @Estado, @AnioPublicacion, @Cantidad);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @Error NVARCHAR(2048) = ERROR_MESSAGE();
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SET NOCOUNT ON;
        INSERT INTO dbo.historialErrores (descripcion) VALUES (LEFT(@Error, 255));
        RAISERROR(N'Error al insertar libro: %s', 16, 1, @Error);
    END CATCH;
END;
GO

CREATE OR ALTER PROC dbo.sp_ActualizarLibro
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
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        IF @Cantidad IS NULL OR @Cantidad < 0
            THROW 50020, N'La cantidad de libros no puede ser negativa ni nula.', 1;
        IF NOT EXISTS (SELECT 1 FROM dbo.Libros WITH (UPDLOCK, HOLDLOCK) WHERE idLibro = @IdLibro)
            THROW 50021, N'No se encontró el libro especificado.', 1;

        -- Cambiar un libro no debe renombrar al autor de otros libros.
        DECLARE @IdAutor INT;
        SELECT TOP (1) @IdAutor = idAutor
        FROM dbo.Autores WITH (UPDLOCK, HOLDLOCK)
        WHERE nombre = @NombreAutor
          AND (nacionalidad = @Nacionalidad OR (nacionalidad IS NULL AND @Nacionalidad IS NULL))
        ORDER BY idAutor;

        IF @IdAutor IS NULL
        BEGIN
            INSERT INTO dbo.Autores (nombre, nacionalidad)
            VALUES (@NombreAutor, @Nacionalidad);
            SET @IdAutor = CONVERT(INT, SCOPE_IDENTITY());
        END;

        UPDATE dbo.Libros
        SET titulo = @Titulo, idAutor = @IdAutor, estado = @Estado,
            anioPublicacion = @AnioPublicacion, cantidad = @Cantidad
        WHERE idLibro = @IdLibro;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @Error NVARCHAR(2048) = ERROR_MESSAGE();
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SET NOCOUNT ON;
        INSERT INTO dbo.historialErrores (descripcion) VALUES (LEFT(@Error, 255));
        RAISERROR(N'Error al actualizar libro: %s', 16, 1, @Error);
    END CATCH;
END;
GO

CREATE OR ALTER PROC dbo.sp_EliminarLibro
    @IdLibro INT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        IF NOT EXISTS (SELECT 1 FROM dbo.Libros WITH (UPDLOCK, HOLDLOCK) WHERE idLibro = @IdLibro)
            THROW 50021, N'No se encontró el libro especificado.', 1;

        IF EXISTS (
            SELECT 1 FROM dbo.DetallePrestamos WITH (UPDLOCK, HOLDLOCK)
            WHERE idLibro = @IdLibro AND (estado IS NULL OR estado <> 'Devuelto')
        )
            THROW 50022, N'No se puede eliminar este libro porque tiene préstamos activos.', 1;

        DECLARE @PrestamosAfectados TABLE (idPrestamo INT PRIMARY KEY);
        INSERT INTO @PrestamosAfectados (idPrestamo)
        SELECT DISTINCT idPrestamo FROM dbo.DetallePrestamos WHERE idLibro = @IdLibro;

        DELETE FROM dbo.DetallePrestamos WHERE idLibro = @IdLibro;

        -- Limpiar únicamente los préstamos de este libro que quedaron sin detalles.
        DELETE p
        FROM dbo.Prestamos AS p
        JOIN @PrestamosAfectados AS a ON a.idPrestamo = p.idPrestamo
        WHERE NOT EXISTS (SELECT 1 FROM dbo.DetallePrestamos AS dp WHERE dp.idPrestamo = p.idPrestamo);

        DELETE FROM dbo.Libros WHERE idLibro = @IdLibro;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @Error NVARCHAR(2048) = ERROR_MESSAGE();
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SET NOCOUNT ON;
        INSERT INTO dbo.historialErrores (descripcion) VALUES (LEFT(@Error, 255));
        RAISERROR(N'Error al eliminar libro: %s', 16, 1, @Error);
    END CATCH;
END;
GO

CREATE OR ALTER PROC dbo.sp_InsertarUsuarioLogin
    @NombreUsuario VARCHAR(50),
    @Email VARCHAR(100),
    @Password VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        IF EXISTS (
            SELECT 1 FROM dbo.UsuarioLogin WITH (UPDLOCK, HOLDLOCK)
            WHERE nombreUsuario = @NombreUsuario OR email = @Email
        )
            THROW 50030, N'El usuario o email ya existe.', 1;

        INSERT INTO dbo.UsuarioLogin (nombreUsuario, email, password, estado)
        VALUES (@NombreUsuario, @Email, @Password, 1);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        DECLARE @Error NVARCHAR(2048) = ERROR_MESSAGE();
        IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
        SET NOCOUNT ON;
        INSERT INTO dbo.historialErrores (descripcion) VALUES (LEFT(@Error, 255));
        RAISERROR(N'Error al insertar usuario login: %s', 16, 1, @Error);
    END CATCH;
END;
GO

CREATE OR ALTER PROC dbo.sp_ValidarLogin
    @NombreUsuario VARCHAR(50),
    @Password VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        SELECT idUsuarioLogin AS IdUsuarioLogin
        FROM dbo.UsuarioLogin
        WHERE nombreUsuario = @NombreUsuario COLLATE Latin1_General_CS_AS
          AND password = @Password COLLATE Latin1_General_100_BIN2
          AND DATALENGTH(password) = DATALENGTH(@Password)
          AND estado = 1;
    END TRY
    BEGIN CATCH
        DECLARE @Error NVARCHAR(2048) = ERROR_MESSAGE();
        INSERT INTO dbo.historialErrores (descripcion) VALUES (LEFT(@Error, 255));
        RAISERROR(N'Error al validar login: %s', 16, 1, @Error);
    END CATCH;
END;
GO

CREATE OR ALTER PROC dbo.sp_ReporteStockLibros
AS
BEGIN
    SET NOCOUNT ON;
    SELECT l.titulo AS Titulo,
           a.nombre AS Autor,
           a.nacionalidad AS NacionalidadAutor,
           l.estado AS EstadoLibro,
           l.anioPublicacion AS FechaPublicacion,
           l.cantidad AS Cantidad
    FROM dbo.Libros AS l
    JOIN dbo.Autores AS a ON l.idAutor = a.idAutor;
END;
GO

CREATE OR ALTER PROC dbo.sp_ReportePrestamo
AS
BEGIN
    SET NOCOUNT ON;
    SELECT Carnet, NombreUsuario, Cargo, TituloLibro, Cantidad,
           FechaPrestamo, FechaDevolucion, Estado
    FROM dbo.vw_detallePrestamo
    WHERE Estado = 'Prestado';
END;
GO
