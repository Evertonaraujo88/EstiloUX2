--ATIVIDADE 5 - DDL

--Uma clínica veterinária deseja cadastrar os animais de estimação que são atendidos em seu local.
-- a clínica contém um endereço;
-- os animais de estimação devem ter nome, data de nascimento, tipo de animal de estimação;
-- os animais de estimação devem ter raça;
-- os animais de estimação devem ter donos;
-- a clínica deseja cadastrar seus veterinários e todo atendimento de pet será feito por um veterinário;
--DML
-- cada atendimento deve registrar qual veterinário atendeu, qual pet foi atendido, descrição da consulta e data da consulta
--DQL
-- listar todos os veterinários (nome e CRMV) de uma clínica (razão social)
-- listar todas as raças que começam com a letra S
-- listar todos os tipos de animais de estimação que terminam com a letra O
-- listar todos os pets mostrando os nomes dos seus donos
-- listar todos os atendimentos mostrando o nome do veterinário que atendeu, o nome, a raça e o tipo do animal de estimação que foi atendido, o nome do dono do animal de estimação e o nome da clínica onde o animal de estimação foi atendido

CREATE DATABASE Exercicio_1_3;

USE Exercicio_1_3;

CREATE TABLE Endereco 
(
	IdEndereco INT PRIMARY KEY IDENTITY,
	Rua VARCHAR (30) NOT NULL,
	Bairro VARCHAR (30) NOT NULL,
	CEP VARCHAR (11) NOT NULL
)

CREATE TABLE Raca
(
	IdRaca INT PRIMARY KEY IDENTITY, 
	NomeRaca VARCHAR (20) NOT NULL
)

CREATE TABLE TipoPet
(
	IdTipoPet INT PRIMARY KEY IDENTITY, 
	NomeTipoPet VARCHAR (20) NOT NULL
)

CREATE TABLE Dono 
(
	IdDono INT PRIMARY KEY IDENTITY,
	NomeDono VARCHAR (50) NOT NULL
)

CREATE TABLE Clinica
(
	IdClinica INT PRIMARY KEY IDENTITY,
	IdEndereco INT FOREIGN KEY REFERENCES Endereco(IdEndereco) NOT NULL
)

CREATE TABLE Veterinario
(
	IdVeterinario INT PRIMARY KEY IDENTITY, 
	IdClinica INT FOREIGN KEY REFERENCES Clinica(IdClinica), 
	NomeVeterinario VARCHAR(50)
)

CREATE TABLE Pet
(
	IdPet INT PRIMARY KEY IDENTITY,
	IdRaca INT FOREIGN KEY REFERENCES Raca(IdRaca) NOT NULL,
	IdTipoPet INT FOREIGN KEY REFERENCES TipoPet(IdTipoPet) NOT NULL,
	IdDono INT FOREIGN KEY REFERENCES Dono(IdDono) NOT NULL,
	Nome VARCHAR (50) NOT NULL,
	Nascimento DATE NOT NULL
)

CREATE TABLE Atendimento
(
	IdAtendimento INT PRIMARY KEY IDENTITY,
	IdVeterinario INT FOREIGN KEY REFERENCES Veterinario(IdVeterinario) NOT NULL,
	IdPet INT FOREIGN KEY REFERENCES Pet(IdPet) NOT NULL,
	DescricaoConsulta VARCHAR (1500),
	DataConsulta DATE
)

--DROP TABLE Veterinario

