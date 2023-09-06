--ATIVIDADE AULA 6 - DML

USE Exercicio_1_2;

INSERT INTO Empresa(Rua,Bairro,CEP)
VALUES ('Rua Maria Florinda','Jardim Bela Vista', '09951-34')

INSERT INTO Marca(NomeMarca)
VALUES ('Volkswagen')

INSERT INTO Modelo(NomeModelo)
VALUES ('Jetta')

INSERT INTO Cliente(Nome, CPF)
VALUES ('Lucas Oliveira','00975368656')

INSERT INTO Veiculo(IdEmpresa,IdMarca,IdModelo,Placa)
VALUES (2,1,1, 'ABC-4323')

INSERT INTO Aluguel(IdVeiculo,IdCliente,Preco,Retirada,Devolucao)
VALUES (1,4,'30.00','01-08-2023','01-08-2023')

DELETE FROM Aluguel
WHERE IdAluguel = 3;

SELECT * FROM Empresa;
SELECT * FROM Marca;
SELECT * FROM Modelo;
SELECT * FROM Cliente;
SELECT * FROM Veiculo;
SELECT * FROM Aluguel;