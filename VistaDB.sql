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



--Mostrar libros listados de libros que estan en prestamos y estan en mora

CREATE OR ALTER VIEW vw_LibrosEnMora 
AS
SELECT 
    l.idLibro AS IdLibro,
    l.titulo AS Titulo,
    a.nombre AS Autor,
    COUNT(dp.idDetallePrestamo) AS CopiasPrestadas,
    (l.cantidad - COUNT(dp.idDetallePrestamo)) AS CopiasDisponibles,
    dp.estado AS Estado
FROM DetallePrestamos dp
INNER JOIN Libros l ON dp.idLibro = l.idLibro
INNER JOIN Autores a ON l.idAutor = a.idAutor
WHERE dp.estado = 'Prestado'
GROUP BY 
    l.idLibro, 
    l.titulo, 
    a.nombre, 
    l.cantidad, 
    dp.estado;
GO

SELECT * FROM vw_LibrosEnMora;

-- Mostrar Usuarios en Mora 
CREATE OR ALTER VIEW vw_UsuariosEnMora AS
SELECT 
    u.idUsuario AS IdUsuario,
    u.carnet AS Carnet,
    u.nombre + ' ' + u.apellido AS Usuarios ,
    COUNT(dp.idDetallePrestamo) AS CantidadLibrosPrestados,
    MIN(p.fechaPrestamo) AS FechaPrestamo,
    MAX(dp.fechaDevolucion) AS FechaDevolucionEsperada
FROM Usuarios u
INNER JOIN Prestamos p ON u.idUsuario = p.idUsuario
INNER JOIN DetallePrestamos dp ON p.idPrestamo = dp.idPrestamo
WHERE dp.estado = 'Prestado'
GROUP BY 
    u.idUsuario,
    u.carnet,
    u.nombre,
    u.apellido;
GO

SELECT * FROM vw_UsuariosEnMora
ORDER BY NombreCompleto;


--Mostrar un stock de los libros
CREATE OR ALTER VIEW vw_StockLibros AS
SELECT 
    l.idLibro AS IdLibro,
    l.titulo AS Titulo,
    a.nombre AS Autor,
    (l.cantidad + ISNULL(SUM(CASE WHEN dp.estado = 'Prestado' THEN dp.cantidad ELSE 0 END), 0)) AS StockCopias,
    ISNULL(SUM(CASE WHEN dp.estado = 'Prestado' THEN dp.cantidad ELSE 0 END), 0) AS CopiasPrestadas,
    l.cantidad AS CopiasDisponibles,
    l.estado AS Estado
FROM Libros l
INNER JOIN Autores a ON l.idAutor = a.idAutor
LEFT JOIN DetallePrestamos dp ON l.idLibro = dp.idLibro
GROUP BY 
    l.idLibro,
    l.titulo,
    a.nombre,
    l.cantidad,
    l.estado;
GO


SELECT * FROM vw_StockLibros ORDER BY Titulo;
