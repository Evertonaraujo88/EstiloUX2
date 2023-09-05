--ATIVIDADE AULA 6 - DML

USE Exercicio_1_3

INSERT INTO Endereco(Rua,Bairro,CEP)
VALUES ('Rua Maria Florinda','Jardim Bela Vista','09951-340')

INSERT INTO TipoPet(NomeTipoPet)
VALUES ('Cachorro')

INSERT INTO Raca(NomeRaca)
VALUES ('Golden')

INSERT INTO Dono(NomeDono)
VALUES ('Lucas')

INSERT INTO Clinica(IdEndereco)
VALUES (1)

INSERT INTO Veterinario(IdClinica, NomeVeterinario)
VALUES (2,'Paulo')

INSERT INTO Pet(IdRaca,IdTipoPet,IdDono,Nome,Nascimento)
VALUES (1,1,1,'Zeus','02-08-2015')

INSERT INTO Atendimento(IdVeterinario,IdPet,DescricaoConsulta,DataConsulta)
VALUES (1,1,'Problema na pata esquerda, o mesmo anda mancando','02-08-2023')

DELETE FROM Clinica
WHERE IdClinica = 3;

SELECT * FROM Endereco;
SELECT * FROM TipoPet;
SELECT * FROM Raca;
SELECT * FROM Dono;
SELECT * FROM Clinica;
SELECT * FROM Veterinario;
SELECT * FROM Pet;
SELECT * FROM Atendimento;