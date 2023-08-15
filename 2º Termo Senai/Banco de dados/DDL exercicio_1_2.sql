USE Exercicio_1_2

CREATE TABLE Empresa(
		
	IdEmpresa INT PRIMARY KEY IDENTITY,
	NomeEmpresa varchar(100),
	CNPJ varchar(15)
);

CREATE TABLE Marca (

	IdMarca INT PRIMARY KEY IDENTITY,
	NomeMarca varchar (50)
);

CREATE TABLE Modelo(
	
	IdModelo INT PRIMARY KEY IDENTITY,
	NomeModelo varchar (50)
);

CREATE TABLE Cliente(

	IdCliente INT PRIMARY KEY IDENTITY,
	NomeCLiente varchar(50),
	CPF varchar(11)
);


CREATE TABLE Veiculo (

	IdVeiculo INT PRIMARY KEY IDENTITY,
	IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa) NOT NULL,
	IdMarca INT FOREIGN KEY REFERENCES Marca(IdMarca) NOT NULL,
	IdModelo INT FOREIGN KEY REFERENCES Modelo(IdModelo) NOT NULL,
	Placa varchar (10)

);

CREATE TABLE Aluguel (

	IdAluguel INT PRIMARY KEY IDENTITY,
	IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente) NOT NULL,
	IdVeiculo INT FOREIGN KEY REFERENCES Veiculo(IdVeiculo) NOT NULL,
	DataRetirada 
);