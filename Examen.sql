--Create Database BioPrinz
USE BioPrinz


CREATE TABLE Comanda(
NrComanda INT NOT NULL IDENTITY,
Desert1 varchar(100),
Desert2 varchar(100),
Desert3 varchar(100),
MainMenu varchar(100),
SecMenu varchar(100),
DataComanda varchar(100),
Adresa varchar(100)
)

SELECT * FROM Comanda;
--DROP TABLE Comanda;