-- ATIVIDADE 6 - DML

USE Exercicio_1_4;

INSERT INTO Usuario(Nome,Email,Senha,Permissao)
VALUES ('Paulo','paulo@gmail.com','12345678','1')

INSERT INTO Estilo(NomeEstilo)
VALUES ('RAP')

INSERT INTO Artista(NomeArtista)
VALUES ('Djonga')

INSERT INTO Album(IdArtista,TempoAlbum,Titulo,DataLancamento,Localizacao,Ativo)
VALUES (1,'03:00:00','Herecia','02-08-23','Brasil','1')
--ARRUMAR O TIME (PESQUISAR)

INSERT INTO AlbumUsuario(IdAlbum,IdUsuario)
VALUES (4,1)

INSERT INTO AlbumEstilo(IdAlbum,IdEstilo)
VALUES (4,1)

SELECT * FROM Usuario;
SELECT * FROM Estilo;
SELECT * FROM Artista;
SELECT * FROM Album;
SELECT * FROM AlbumUsuario;
SELECT * FROM AlbumEstilo;
