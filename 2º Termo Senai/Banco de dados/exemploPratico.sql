USE Teste



CREATE TABLE Pedidos(

	IdPedidos INT PRIMARY KEY IDENTITY,
	Descricao varchar(200),
	Valor varchar (10)
)



CREATE TABLE RegistroPedidos (
	IdRegistroPedidos INT PRIMARY KEY IDENTITY ,
	IdPedidos INT FOREIGN KEY REFERENCES Pedidos (IdPedidos) NOT NULL,
	DataRegistro varchar (30) NOT NULL

)






CREATE TRIGGER InseriRegistroPedido
ON Pedidos
AFTER INSERT
AS
BEGIN
    INSERT INTO RegistroPedidos (IdPedidos, DataRegistro)
    SELECT IdPedidos, GETDATE() FROM inserted;
END;








INSERT INTO Pedidos (Descricao, Valor)
VALUES

	('50 tijolos', 119.90),
	('10 sacos de CImento', 360.60),
	('3 metros de areia', 450.00)








SELECT * FROM Pedidos

SELECT * FROM RegistroPedidos