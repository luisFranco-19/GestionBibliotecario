-- SQL Server 2016 SP1 o posterior. Ejecutar primero este archivo completo.
-- Conserva BibliotecaDB y sus datos si la base ya existe.
USE [master];
GO
IF DB_ID(N'BibliotecaDB') IS NULL
    EXEC(N'CREATE DATABASE [BibliotecaDB];');
GO
USE [BibliotecaDB];
GO
SET XACT_ABORT ON;
SET NOCOUNT ON;

BEGIN TRY
    BEGIN TRANSACTION;

    IF OBJECT_ID(N'dbo.Usuarios', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.Usuarios (
            idUsuario INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Usuarios PRIMARY KEY,
            carnet VARCHAR(15) NOT NULL CONSTRAINT UQ_Usuarios_Carnet UNIQUE,
            nombre VARCHAR(70) NOT NULL,
            apellido VARCHAR(70) NOT NULL,
            telefono VARCHAR(15) NOT NULL CONSTRAINT UQ_Usuarios_Telefono UNIQUE,
            email VARCHAR(70) NOT NULL CONSTRAINT UQ_Usuarios_Email UNIQUE,
            cargo VARCHAR(10) NOT NULL,
            fechaRegistro DATE NOT NULL CONSTRAINT DF_Usuarios_FechaRegistro DEFAULT GETDATE(),
            CONSTRAINT CHK_Cargo CHECK (cargo IN ('Docente', 'Alumno'))
        );
    END;

    IF OBJECT_ID(N'dbo.Autores', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.Autores (
            idAutor INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Autor PRIMARY KEY,
            nombre VARCHAR(70) NOT NULL,
            nacionalidad VARCHAR(50) NULL,
            fechaRegistro DATETIME NOT NULL CONSTRAINT DF_Autores_FechaRegistro DEFAULT GETDATE()
        );
    END;

    IF OBJECT_ID(N'dbo.Libros', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.Libros (
            idLibro INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Libros PRIMARY KEY,
            idAutor INT NOT NULL,
            titulo VARCHAR(100) NOT NULL,
            estado VARCHAR(10) NOT NULL CONSTRAINT DF_Libros_Estado DEFAULT 'Activo',
            anioPublicacion INT NULL,
            cantidad INT NOT NULL,
            fechaRegistro DATETIME NOT NULL CONSTRAINT DF_Libros_FechaRegistro DEFAULT GETDATE(),
            CONSTRAINT FK_Autores FOREIGN KEY (idAutor) REFERENCES dbo.Autores(idAutor),
            CONSTRAINT CHK_Estado CHECK (estado IN ('Activo', 'Inactivo'))
        );
    END;

    -- Compatibilidad con bases anteriores: no volver a agregar columnas existentes.
    IF COL_LENGTH(N'dbo.Autores', N'fechaRegistro') IS NULL
        ALTER TABLE dbo.Autores ADD fechaRegistro DATETIME NOT NULL
            CONSTRAINT DF_Autores_FechaRegistro DEFAULT GETDATE() WITH VALUES;
    IF COL_LENGTH(N'dbo.Libros', N'fechaRegistro') IS NULL
        ALTER TABLE dbo.Libros ADD fechaRegistro DATETIME NOT NULL
            CONSTRAINT DF_Libros_FechaRegistro DEFAULT GETDATE() WITH VALUES;

    IF OBJECT_ID(N'dbo.Prestamos', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.Prestamos (
            idPrestamo INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Prestamos PRIMARY KEY,
            idUsuario INT NOT NULL,
            fechaPrestamo DATE NOT NULL CONSTRAINT DF_Prestamos_FechaPrestamo DEFAULT GETDATE(),
            -- En la aplicación esta columna contiene la fecha prevista de devolución.
            fechaDevolucion DATE NULL,
            CONSTRAINT FK_Prestamos_Usuarios FOREIGN KEY (idUsuario) REFERENCES dbo.Usuarios(idUsuario),
            CONSTRAINT CHK_Fechas CHECK (fechaDevolucion IS NULL OR fechaDevolucion >= fechaPrestamo)
        );
    END;

    IF OBJECT_ID(N'dbo.DetallePrestamos', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.DetallePrestamos (
            idDetallePrestamo INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_DetallePrestamos PRIMARY KEY,
            idPrestamo INT NOT NULL,
            idLibro INT NOT NULL,
            cantidad INT NOT NULL,
            -- La aplicación usa la fecha prevista mientras está Prestado y la real al devolver.
            fechaDevolucion DATE NULL,
            estado VARCHAR(15) NOT NULL CONSTRAINT DF_DetallePrestamos_Estado DEFAULT 'Prestado',
            CONSTRAINT FK_DetallePrestamos_Prestamos FOREIGN KEY (idPrestamo) REFERENCES dbo.Prestamos(idPrestamo),
            CONSTRAINT FK_DetallePrestamos_Libros FOREIGN KEY (idLibro) REFERENCES dbo.Libros(idLibro)
        );
    END;

    IF OBJECT_ID(N'dbo.UsuarioLogin', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.UsuarioLogin (
            idUsuarioLogin INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_UsuarioLogin PRIMARY KEY,
            nombreUsuario VARCHAR(50) NOT NULL CONSTRAINT UQ_UsuarioLogin_Nombre UNIQUE,
            email VARCHAR(100) NOT NULL CONSTRAINT UQ_UsuarioLogin_Email UNIQUE,
            -- Se almacena el valor recibido de la aplicación; este script no lo cifra.
            password VARCHAR(255) NOT NULL,
            fechaCreacion DATETIME NOT NULL CONSTRAINT DF_UsuarioLogin_FechaCreacion DEFAULT GETDATE(),
            estado BIT NOT NULL CONSTRAINT DF_UsuarioLogin_Estado DEFAULT 1
        );
    END;

    IF OBJECT_ID(N'dbo.InicioSesion', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.InicioSesion (
            idLogin INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_InicioSesion PRIMARY KEY,
            idUsuarioLogin INT NOT NULL,
            fechaLogin DATETIME NOT NULL CONSTRAINT DF_InicioSesion_FechaLogin DEFAULT GETDATE(),
            exito BIT NOT NULL,
            CONSTRAINT FK_InicioSesion_UsuarioLogin FOREIGN KEY (idUsuarioLogin)
                REFERENCES dbo.UsuarioLogin(idUsuarioLogin)
        );
    END;

    IF OBJECT_ID(N'dbo.historialErrores', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.historialErrores (
            idError INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_historialErrores_idError PRIMARY KEY,
            descripcion VARCHAR(255) NOT NULL,
            fechaRegistro DATETIME NOT NULL CONSTRAINT DF_historialErrores_FechaRegistro DEFAULT GETDATE()
        );
    END;

    -- Si existen datos inválidos, informar y revertir la actualización del esquema.
    -- No corregir cantidades ni estados automáticamente.
    IF EXISTS (SELECT 1 FROM dbo.Libros WHERE cantidad < 0)
        THROW 50001, N'Hay libros con cantidad negativa. Corrija esos datos antes de ejecutar el script.', 1;
    IF EXISTS (SELECT 1 FROM dbo.DetallePrestamos WHERE cantidad <= 0)
        THROW 50002, N'Hay detalles de préstamo con cantidad no positiva. Corrija esos datos primero.', 1;
    IF EXISTS (SELECT 1 FROM dbo.DetallePrestamos WHERE estado IS NOT NULL AND estado NOT IN ('Prestado', 'Devuelto'))
        THROW 50003, N'Hay estados de préstamo distintos de Prestado o Devuelto. Revise esos datos primero.', 1;

    IF OBJECT_ID(N'dbo.CHK_Libros_Cantidad', N'C') IS NULL
        ALTER TABLE dbo.Libros WITH CHECK ADD CONSTRAINT CHK_Libros_Cantidad CHECK (cantidad >= 0);
    IF OBJECT_ID(N'dbo.CHK_DetallePrestamos_Cantidad', N'C') IS NULL
        ALTER TABLE dbo.DetallePrestamos WITH CHECK ADD CONSTRAINT CHK_DetallePrestamos_Cantidad CHECK (cantidad > 0);
    IF OBJECT_ID(N'dbo.CHK_DetallePrestamos_Estado', N'C') IS NULL
        ALTER TABLE dbo.DetallePrestamos WITH CHECK ADD CONSTRAINT CHK_DetallePrestamos_Estado
            CHECK (estado IN ('Prestado', 'Devuelto'));

    ALTER TABLE dbo.Libros WITH CHECK CHECK CONSTRAINT CHK_Libros_Cantidad;
    ALTER TABLE dbo.DetallePrestamos WITH CHECK CHECK CONSTRAINT CHK_DetallePrestamos_Cantidad;
    ALTER TABLE dbo.DetallePrestamos WITH CHECK CHECK CONSTRAINT CHK_DetallePrestamos_Estado;

    COMMIT TRANSACTION;
    PRINT N'Esquema de BibliotecaDB preparado. Ejecute Vista.sql a continuación.';
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0 ROLLBACK TRANSACTION;
    THROW;
END CATCH;
GO
