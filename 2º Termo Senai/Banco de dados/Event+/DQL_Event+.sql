--Nome do usu�rio
--Tipo do usu�rio
--Data do evento
--Local do evento (Institui��o)
--Titulo do evento
--Nome do evento
--Descri��o do evento
--Situa��o do evento
--Coment�rio do evento

--usar join

USE Eventplus_manha;

SELECT --Seleciona os itens e a ordem que quero trazer as colunas da tabela
Usuario.NomeUsuario AS "Nome do Usu�rio",
TiposDeUsuario.TituloTipoUsuario AS "Tipo do Usuario",
Evento.DataEvento AS "Data do Evento",
CONCAT (Instituicao.NomeFantasia , ' ',Instituicao.Endereco) AS "Local",
TiposDeEvento.TituloTipoEvento AS "Tipo do Evento ",
Evento.Nome AS "Nome do Evento",
Evento.Descricao AS "Descri��o do Evento", 
CASE WHEN PresensaEventos.Situacao = 1 THEN 'Confirmada' ELSE 'N�o Confirmada' END AS "Situa��o",
ComentarioEvento.Descricao AS "Coment�rio"
FROM Evento
JOIN TiposDeEvento
ON Evento.IdTipoDeEvento = TiposDeEvento.IdTipoDeEvento

JOIN Instituicao
ON Evento.IdInstituicao = Instituicao.IdInstituicao

JOIN PresensaEventos
ON Evento.IdEvento = PresensaEventos.IdEvento

JOIN Usuario
ON PresensaEventos.IdUsuario = Usuario.IdUsuario

JOIN TiposDeUsuario
ON TiposDeUsuario.IdTiposDeUsuario = Usuario.IdTiposDeUsuario

LEFt JOIN ComentarioEvento
ON ComentarioEvento.IdUsuario = Usuario.IdUsuario



		
	