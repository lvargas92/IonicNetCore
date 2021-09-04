CREATE DATABASE Noticias;

-- DROP SCHEMA dbo;

CREATE SCHEMA dbo;
-- Noticias.dbo.Autor definition

-- Drop table

-- DROP TABLE Noticias.dbo.Autor;

CREATE TABLE Noticias.dbo.Autor (
	AutorID int IDENTITY(1,1) NOT NULL,
	Nombre varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Apellido varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Autor__F58AE909981B1D8B PRIMARY KEY (AutorID)
);


-- Noticias.dbo.Noticia definition

-- Drop table

-- DROP TABLE Noticias.dbo.Noticia;

CREATE TABLE Noticias.dbo.Noticia (
	NoticiaID int IDENTITY(1,1) NOT NULL,
	Titulo varchar(120) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Descripcion varchar(200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Contenido varchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Fecha datetime NULL,
	AutorID int NULL,
	CONSTRAINT PK__Noticia__F33000EF66DD0C3C PRIMARY KEY (NoticiaID)
);
