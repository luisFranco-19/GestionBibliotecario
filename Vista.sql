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
GO



SELECT *
FROM vw_detallePrestamo
ORDER BY 
    CASE Estado 
        WHEN 'Prestado' THEN 1
        WHEN 'Devuelto' THEN 2
        ELSE 3
    END,
    FechaPrestamo DESC;

-- Mostrar el historial de libros no devueltos por el usuario o que estan 
-- en prestamo 
CREATE OR ALTER VIEW vw_LibrosPrestados AS
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
SELECT * FROM vw_LibrosPrestados



-- Usuarios con mas prestamos
USE BibliotecaDB;
GO

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
GO

SELECT * FROM vw_Top10LibrosPopulares

--cantidad de usuarios por tipo (Docente o Alumno).
CREATE OR ALTER VIEW vw_DistribucionUsuarios
AS
SELECT 
    cargo AS TipoUsuario,
    COUNT(*) AS Total
FROM Usuarios
GROUP BY cargo;
GO

SELECT * FROM vw_DistribucionUsuarios