--ATIVIDADE 5 - DDL

--Construa o Modelo Entidade Relacionamento considerando o seguinte cenário:
-- uma empresa possui vários veículos
-- um veículo possui marca(gm, ford, fiat), modelo(onix, fiesta, argo) e placa
-- um cliente (cpf, nome) alugado um ou mais veículos
--DML
-- um registro de aluguel deve conter qual cliente alugou, o veículo alugado, dados de retirada e dados de devolução
--DQL
-- listar todos os alugueis mostrando como datas de início e fim, o nome do cliente que alugou e nome do modelo do carro
-- listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro

--PASSO 1 CRIAR UMA DATABASE (BASE DE DADOS)
CREATE DATABASE Exercicio_1_2;

--PASSO 2 COMANDO PARA USAR O BANCO DE DADOS
USE Exercicio_1_2;

--PASSO 3 CRIAR AS TABELAS (começa sempre pela que não tem chave estrangeira)
CREATE TABLE Empresa 
(
	IdEmpresa INT PRIMARY KEY IDENTITY,
	Rua VARCHAR(50) NOT NULL,
	Bairro VARCHAR (50) NOT NULL,
	CEP VARCHAR (8) NOT NULL
)

CREATE TABLE Modelo
(
	IdModelo INT PRIMARY KEY IDENTITY,
	NomeModelo VARCHAR (20) NOT NULL
)

CREATE TABLE Marca
(
	IdMarca INT PRIMARY KEY IDENTITY,
	NomeMarca VARCHAR (20) NOT NULL
)

CREATE TABLE Cliente 
(
	IdCliente INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (50) NOT NULL,
	CPF VARCHAR (11) NOT NULL
)

CREATE TABLE Veiculo 
(
	IdVeiculo INT PRIMARY KEY IDENTITY,
	IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa),
	IdMarca INT FOREIGN KEY REFERENCES Marca(IdMarca),
	IdModelo INT FOREIGN KEY REFERENCES Modelo(IdModelo),
	Placa VARCHAR (10) NOT NULL
)

CREATE TABLE Aluguel
(
	IdAluguel INT PRIMARY KEY IDENTITY,
	IdVeiculo INT FOREIGN KEY REFERENCES Veiculo(IdVeiculo),
	IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente),
	Preco SMALLMONEY,
	Retirada DATE,
	Devolucao DATE
)