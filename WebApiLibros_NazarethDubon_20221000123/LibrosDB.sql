CREATE DATABASE LibrosDB;
GO

USE LibrosDB;
GO

CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);
GO

CREATE TABLE Libros (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(200) NOT NULL,
    Descripcion NVARCHAR(500) NOT NULL,
    CategoriaId INT NOT NULL,
    Activo BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Libros_Categorias FOREIGN KEY (CategoriaId)
        REFERENCES Categorias(Id)
);
GO

INSERT INTO Categorias (Nombre, Activo) VALUES
('Ficción', 1),
('Ciencia', 1),
('Historia', 1);

INSERT INTO Libros (Nombre, Descripcion, CategoriaId, Activo) VALUES
('Cien Años de Soledad', 'Novela de Gabriel García Márquez', 1, 1),
('Breve Historia del Tiempo', 'Libro de Stephen Hawking sobre cosmología', 2, 1),
('Sapiens', 'Historia de la humanidad por Yuval Noah Harari', 3, 1);
GO