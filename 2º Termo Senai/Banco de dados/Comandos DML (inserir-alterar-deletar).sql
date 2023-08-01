--DML (Data Manipulation Language)

USE Teste;

--Inserir dados na tabela
INSERT INTO Funcionarios( Nome)
VALUES ('gabi');

--ALterar dados na tabela
UPDATE Funcionarios
SET Nome = 'Andre' WHERE Nome = 'gabi'

--Excluir dados na tabela`	7UJM 0-\P[
;>?DELETE FROM Funcionarios
WHERE IdFuncionario = 3