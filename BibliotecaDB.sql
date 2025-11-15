USE master
GO

CREATE DATABASE BibliotecaDB;
GO

USE BibliotecaDB;
GO

CREATE TABLE Usuarios (
    idUsuario INT IDENTITY(1,1) NOT NULL,
    carnet VARCHAR(15) NOT NULL UNIQUE,
    nombre VARCHAR(70) NOT NULL,
    apellido VARCHAR(70) NOT NULL,
    telefono VARCHAR(15) NOT NULL UNIQUE,
    email VARCHAR(70) NOT NULL UNIQUE,
    cargo VARCHAR(10) NOT NULL,
    fechaRegistro DATE NOT NULL DEFAULT GETDATE(),

    CONSTRAINT PK_Usuarios PRIMARY KEY (idUsuario),
    CONSTRAINT CHK_Cargo CHECK (cargo IN ('Docente', 'Alumno'))
);
GO


CREATE TABLE Autores (
    idAutor INT IDENTITY(1,1) NOT NULL,
    nombre VARCHAR(70) NOT NULL,
    nacionalidad VARCHAR(50),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Autor PRIMARY KEY (idAutor)
);
GO

CREATE TABLE Libros (
    idLibro INT IDENTITY(1,1) NOT NULL,
    idAutor INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    estado VARCHAR(10) NOT NULL DEFAULT 'Activo',
    anioPublicacion INT,
    cantidad INT NOT NULL,
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_Libros PRIMARY KEY (idLibro),
    CONSTRAINT FK_Autores FOREIGN KEY (idAutor) REFERENCES Autores(idAutor),
    CONSTRAINT CHK_Estado CHECK (estado IN ('Activo', 'Inactivo'))
);
GO

ALTER TABLE Autores
ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO

ALTER TABLE Libros
ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
GO



CREATE TABLE Prestamos (
    idPrestamo INT IDENTITY(1,1) NOT NULL,
    idUsuario INT NOT NULL,
    fechaPrestamo DATE NOT NULL DEFAULT GETDATE(),
    fechaDevolucion DATE,
	--estado VARCHAR(10) NOT NULL DEFAULT 'Activo'


    CONSTRAINT PK_Prestamos PRIMARY KEY (idPrestamo) ,
    CONSTRAINT FK_Prestamos_Usuarios FOREIGN KEY (idUsuario) REFERENCES Usuarios(idUsuario),
	CONSTRAINT CHK_Fechas CHECK (fechaDevolucion IS NULL OR fechaDevolucion >= fechaPrestamo),
	--CONSTRAINT CHK_Estado_Prestamo CHECK (estado IN ('Activo', 'Inactivo'))
);
GO

CREATE TABLE DetallePrestamos (
    idDetallePrestamo INT IDENTITY(1,1) PRIMARY KEY,
    idPrestamo INT NOT NULL,
    idLibro INT NOT NULL,
    cantidad INT NOT NULL,
    fechaDevolucion DATE NULL,

    estado VARCHAR(15) NULL CONSTRAINT DF_DetallePrestamos_Estado DEFAULT 'Prestado',
    CONSTRAINT FK_DetallePrestamos_Prestamos FOREIGN KEY (idPrestamo) REFERENCES Prestamos(idPrestamo),
    CONSTRAINT FK_DetallePrestamos_Libros FOREIGN KEY (idLibro) REFERENCES Libros(idLibro)
);
GO

-- Crear la tabla inicioSeccion
CREATE TABLE UsuarioLogin (
    idUsuarioLogin INT IDENTITY(1,1) PRIMARY KEY,
    nombreUsuario VARCHAR(50) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL, -- Aquí se guarda la contraseña encriptada
    fechaCreacion DATETIME DEFAULT GETDATE(),
    estado BIT DEFAULT 1 -- 1 = activo, 0 = inactivo
); 
GO

CREATE TABLE InicioSesion (
    idLogin INT IDENTITY(1,1) PRIMARY KEY,
    idUsuarioLogin INT NOT NULL,
    fechaLogin DATETIME DEFAULT GETDATE(),
    exito BIT NOT NULL, -- 1 = login correcto, 0 = login fallido
    FOREIGN KEY (idUsuarioLogin) REFERENCES UsuarioLogin (idUsuarioLogin)
);
GO


CREATE TABLE historialErrores(
    idError INT IDENTITY,
    descripcion VARCHAR(255) NOT NULL,
    fechaRegistro DATETIME DEFAULT GETDATE() NOT NULL

    CONSTRAINT [PK_historialErrores_idError] PRIMARY KEY(idError)
);
GO

 SELECT * FROM UsuarioLogin
 SELECT * FROM InicioSesion

-- eliminamos los registros en InicioSesion asociados al usuario
DELETE FROM InicioSesion
WHERE idUsuarioLogin = 1;

-- eliminamos el usuario de UsuarioLogin
DELETE FROM UsuarioLogin
WHERE idUsuarioLogin = 1;
