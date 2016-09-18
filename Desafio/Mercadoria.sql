CREATE DATABASE MERCADORIAS

CREATE TABLE MERCADORIA(
	CodigoMerc INT IDENTITY  PRIMARY KEY,
	TipoMercadoria varchar(100) Not Null,
	Nome varchar (100) Not Null,
	Quantidade int Not Null,
	Preco decimal (10,2) Not Null,
	Tipo char(2) Not null

)