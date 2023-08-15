--DML (Data Minupulation Language)
USE Eventplus_manha;

--Inserir dados nas tabelas

INSERT INTO TiposDeUsuario(TituloTipoUsuario) 
VALUES 
	('Adminitrador'),
	('Comum')


INSERT INTO TiposDeEvento(TituloTipoEvento) 
VALUES 
	('SQL Server')

INSERT INTO Instituicao(CNPJ, NomeFantasia, Endereco) 
VALUES 
	('12345678912345', 'DevScholl', 'Rua Niteroi,180')

INSERT INTO Usuario(IdTiposDeUsuario, NomeUsuario, Email, Senha) 
VALUES 
	(1, 'Everton', 'everton@eventplus.com.br', '1234')

INSERT INTO Evento(IdTipoDeEvento, IdInstituicao, Nome, Descricao, DataEvento, HorarioEvento) 
VALUES 
	(1, 1, 'Introdução ao banco de dados SQL Server', 'Aprensa conceitos básicos do SQL Server', '2023-08-10', '10:00:00')

INSERT INTO PresensaEventos(IdUsuario, IdEvento) 
VALUES 
	(2, 1)

INSERT INTO ComentarioEvento(IdUsuario, IdEvento, Descricao, Exibe)
VALUES
	(2, 1, 'Excelente evento, professor top!!!', 1)

	SELECT * FROM Usuario
	SELECT * FROM TiposDeUsuario
	SELECT * FROM TiposDeEvento
	SELECT * FROM Instituicao
	SELECT * FROM Evento
	SELECT * FROM PresensaEventos
	SELECT * FROM ComentarioEvento