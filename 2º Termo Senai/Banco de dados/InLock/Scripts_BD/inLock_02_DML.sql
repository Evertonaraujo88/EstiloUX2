USE inlock_games_codeFisrst_manha;
GO

INSERT INTO Estudio
VALUES (NEWID(),'Blizzard'),(NEWID(),'Rockstar Studios'),(NEWID(),'Square Enix');
GO

select * from Estudio

INSERT INTO Jogo
VALUES (NEWID(),'Diablo 3','É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã.','2012-09-24',2, '35B9E37B-41AE-4544-91B6-D5CE479C6C3F')
	  ,(NEWID(),'Red Dead Redemption II','Jogo eletrônico de ação-aventura western.','2012-09-27',12, '7FAB2740-5C41-4694-8750-8ACEB1E45642');
GO
select * from Jogo

INSERT INTO TiposUsuario
VALUES  (NEWID(),'Comum'),
		(NEWID(),'Administrador');
GO


INSERT INTO Usuario
VALUES (NEWID(),'comum@comum.com','comum','16F63C68-BCB1-432A-B8CE-D0E78FECBB30'),
		(NEWID(),'admin@admin.com','admin','C6BDBD5B-E95B-45D9-99D5-D9366B50DE0A' );


GO
select * from Usuario
select * from TiposUsuario

