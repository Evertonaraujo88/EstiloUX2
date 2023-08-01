--DDL (Data Definition Language)

-- Cria um banco de dados
CREATE DATABASE Teste;
--usa o banco de dados criado

GO

USE Teste;
GO
--cria uma tabela
CREATE TABLE Funcionarios(
		
	IdFuncionario INT PRIMARY KEY IDENTITY,
	Nome varchar(100)
);

CREATE TABLE Empresas(
	IdEmpresa INT PRIMARY KEY IDENTITY,
	IdFuncionario INT FOREIGN KEY REFERENCES Funcionarios(IdFuncionario),
	NomeEmpresa VARCHAR(100),
	
)

--Altera a tabela
ALTER TABLE Funcionarios

--exclui a coluna desejada
DROP COLUMN Nome;

ALTER TABLE Funcionarios
ADD Nome varchar(100);

--apaga a tabela
DROP TABLE Funcionarios;

--Apaga o banco de dados desejado
DROP DATABASE Teste;