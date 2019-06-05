CREATE DATABASE PersonasDb
GO

USE PersonasDb
GO

CREATE TABLE Personas
(
	ID INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(30),
	Telefono VARCHAR(13),
	Cedula VARCHAR(13),
	Direccion VARCHAR(MAX) 
);