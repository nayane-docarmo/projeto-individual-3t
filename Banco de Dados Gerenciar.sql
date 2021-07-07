CREATE DATABASE Gerenciar 

CREATE TABLE Sala_Equipamento(
	IdSala_Equipamento INT PRIMARY KEY IDENTITY NOT NULL,
	IdSala INT FOREIGN KEY REFERENCES Sala (IdSala),
	IdEquipamento INT FOREIGN KEY REFERENCES Equipamento (IdEquipamento),
	Descricao VARCHAR (250) NOT NULL,
	DataEntrada DATETIME,
	StatusG BINARY DEFAULT 0
);
CREATE TABLE Sala(
 IdSala INT PRIMARY KEY IDENTITY NOT NULL,
 Andar INt NOT NULL,
 Nome VARCHAR (50) NOT NULL,
 Metragem float NOT NULL
 );
CREATE TABLE Equipamento(
	IdEquipamento  INT PRIMARY KEY IDENTITY NOT NULL,
	Marca VARCHAR(50) NOT NULL,
	NSerie INT NOT NULL,
	NPatrimonio INT NOT NULL,
	Tipo VARCHAR (100) NOT NULL,
	Disponivel Binary DEFAULT 0
);
CREATE TABLE Usuario(
	IdUsuario INT PRIMARY KEY IDENTITY NOT NULL, 
	Nome VARCHAR(50) NOT NULL,
	CPF VARCHAR NOT NULL,
	Setor VARCHAR(100) NOT NULL
);


SELECT * FROM Usuario
SELECT * FROM Equipamento
SELECT * FROM Sala
SELECT * FROM Sala_Equipamento

INSERT INTO Usuario (Nome, CPF, Setor) VALUES ('Claudio' ,'36578845' , 'Informatica');
INSERT INTO Equipamento (Marca, NSerie, NPatrimonio, Tipo, Disponivel) VALUES ('weibo', 4123, 6565, 'Teclado', 1);
INSERT INTO Sala (Andar, Nome, Metragem) VALUES (2, 'Informatica', 2.4);
INSERT INTO Sala_Equipamento(IdSala, IdEquipamento, Descricao, DataEntrada, StatusG) VALUES (1, 2, 'sla',convert(datetime,'18-06-12 11:15:00 AM'), 1);

