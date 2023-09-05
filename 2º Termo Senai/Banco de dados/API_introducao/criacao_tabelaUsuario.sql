use Filmes;

CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Email VARCHAR (50) NOT NULL UNIQUE,
	Senha VARCHAR(50) NOT NULL,
	Permissao VARCHAR (20) NOT NULL
);

INSERT INTO Usuario VALUES 
('Admin@admin.com', 'adm1234', 'Administrador'),
('comum@comum.com', '1234', 'Comum');


DROP TABLE Usuario