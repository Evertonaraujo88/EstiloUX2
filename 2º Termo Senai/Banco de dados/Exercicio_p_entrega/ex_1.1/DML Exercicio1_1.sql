USE Exercicio1_1;

INSERT INTO Pessoa(Nome, CNH)
VALUES ('Guilherme',44323980660),
		('Kelvin',05092784216)

INSERT INTO Email(IdPessoa, NomeEmail)
VALUES (1, 'zealuno@senaiinsert'),
		(2, 'pedro@pedro.com'),
		(3, 'gabriel@gabriel.com'),
		(4, 'joao@joao.com'),
		(5, 'guilherme@guilherme.com'),
		(6, 'kelvin@kelvin.com')


INSERT INTO Telefone(IdPessoa, NumeroTelefone) 
VALUES
	(5,'5509225242857'),
	(1,'55092939371151'),
	(3,'5504322758271'),
	(4,'5582039618933'),
	(2,'5515935346802')