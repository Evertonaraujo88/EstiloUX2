--ATIVIDADE 5 - DDL

--A Optus é uma empresa no ramo musical que deseja realizar o gerenciamento dos lançamentos de novos cds de seus artistas. Cada álbum lançado poderá conter mais de um estilo vinculado (ex.: Indie e Folk).
--É importante que você crie também uma estratégia para que os usuários possuam acesso à plataforma.
--Os usuários devem conter nome, e-mail, senha e tipo de permissão (eles podem ser do tipo administrador ou comum).

--Observações:
--Os Artistas devem possuir somente o nome.
--Estilos: nome.
--Álbuns: título, data de lançamento, localização, quantidade de minutos, se o álbum está ativo para visualização, a quem pertence (somente um artista por álbum) e quais os estilos vinculados.

--DQL

--listar todos os usuários administradores, sem exibir suas senhas
--listar todos os álbuns lançados após o um determinado ano de lançamento
--listar os dados de um usuário através do e-mail e senha
--listar todos os álbuns ativos, mostrando o nome do artista e os estilos do álbum 


CREATE DATABASE Exercicio_1_4;

USE Exercicio_1_4;

CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) NOT NULL,
	Email VARCHAR(70) NOT NULL,
	Senha VARCHAR(8) NOT NULL,
	Permissao BIT NOT NULL,
)

CREATE TABLE Estilo 
(
	IdEstilo INT PRIMARY KEY IDENTITY,
	NomeEstilo VARCHAR(50) NOT NULL
)

CREATE TABLE Artista
(
	IdArtista INT PRIMARY KEY IDENTITY,
	NomeArtista VARCHAR(50) NOT NULL
)

CREATE TABLE Album 
(
	IdAlbum INT PRIMARY KEY IDENTITY,
	IdArtista INT FOREIGN KEY REFERENCES Artista(IdArtista) NOT NULL,
	TempoAlbum TIME NOT NULL,
	Titulo VARCHAR(30) NOT NULL,
	DataLancamento DATE NOT NULL,
	Localizacao VARCHAR (50) NOT NULL,
	Ativo BIT NOT NULL
)

CREATE TABLE AlbumUsuario
(
	IdAlbumUsuario INT PRIMARY KEY IDENTITY,
	IdAlbum INT FOREIGN KEY REFERENCES Album(IdAlbum) NOT NULL,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL
)

CREATE TABLE AlbumEstilo
(
	IdAlbumEstilo INT PRIMARY KEY IDENTITY,
	IdAlbum INT FOREIGN KEY REFERENCES Album(IdAlbum) NOT NULL,
	IdEstilo INT FOREIGN KEY REFERENCES Estilo(IdEstilo) NOT NULL,
)