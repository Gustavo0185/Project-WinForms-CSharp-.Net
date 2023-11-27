CREATE DATABASE PayrollTech;

CREATE TABLE tblfuncionario
(
    funid int PRIMARY KEY,
    funnome varchar(50),
    funidade int,
    funcpf  Bigint,
    funpis Bigint,
    funsexo varchar(50),
);

CREATE TABLE tblcargo
(
    carid int PRIMARY KEY,
	carcargo varchar (30),
	carsalario DECIMAL,
);

create table tblextrato
(
 id int ,
 nome VARCHAR (50) ,
 cargo VARCHAR (50) ,
 salabr Decimal (10,2)  ,
 vlhr Decimal (10,2),
 impr Decimal (10,2) ,
 inss Decimal (10,2),
 salali Decimal (10,2)
);

CREATE TABLE Usuarios
(
    Username varchar (50)  PRIMARY KEY,
    Password varchar(50),
 
);