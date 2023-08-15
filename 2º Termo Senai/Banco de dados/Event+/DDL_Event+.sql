--DDL (Database Definition Language

--Criar Banco de Dados
CREATE DATABASE Eventplus_manha;

USE Eventplus_manha;

--Criar Tabelas
CREATE TABLE TiposDeUsuario(
	IdTiposDeUsuario INT PRIMARY KEY IDENTITY,
	TituloTipoUsuario VARCHAR (100) NOT NULL UNIQUE
);

CREATE TABLE Instituicao(
	IdInstituicao INT PRIMARY KEY IDENTITY,
	CNPJ CHAR (14) NOT NULL UNIQUE,
	NomeFantasia VARCHAR (100) NOT NULL,
	Endereco VARCHAR (100) NOT NULL,
);

CREATE TABLE TiposDeEvento(
	IdTipoDeEvento INT PRIMARY KEY IDENTITY,
	TituloTipoEvento VARCHAR (50) NOT NULL UNIQUE,
);

CREATE TABLE Usuario (
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoDeUsuario INT FOREIGN KEY REFERENCES TiposDeUsuario (IdTiposDeUsuario) NOT NULL,
	NomeUsuario VARCHAR (100) NOT NULL,
	Email VARCHAR (256) NOT NULL UNIQUE,
	Senha VARCHAR (100) NOT NULL  
);

CREATE TABLE Evento (
	IdEvento INT PRIMARY KEY IDENTITY,
	IdTipoDeEvento INT FOREIGN KEY REFERENCES TiposDeEvento (IdTipoDeEvento) NOT NULL,
	IdInstituicao INT FOREIGN KEY REFERENCES Instituicao (IdInstituicao) NOT NULL,
	Nome VARCHAR (100) NOT NULL,
	Descricao VARCHAR (100) NOT NULL,
	DataEvento DATE NOT NULL,
	HorarioEvento Time NOT NULL
	);

CREATE TABLE PresensaEventos(
	IdPresencaEvento INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
	IdEvento INT FOREIGN KEY REFERENCES Evento (IdEvento) NOT NULL,
	Situacao BIT DEFAULT (0)
);

CREATE TABLE ComentarioEvento (
	IdComentarioEvento INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
	IdEvento INT FOREIGN KEY REFERENCES Evento (IdEvento) NOT NULL,
	Descricao VARCHAR (256) NOT NULL,
	Exibe BIT DEFAULT (0)
);