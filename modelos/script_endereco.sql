CREATE TABLE Endereco
(
	idendereco             integer NOT NULL identity(1,1) ,
	logradouro             VARCHAR(500) NOT NULL ,
	numero                 int NULL ,
	dscomplemento          varchar(200)  null,
	idbairro               int null,
	flativo                CHAR(1) NOT NULL ,
	constraint XPKEndereco primary key(idendereco),
	constraint XFKEndBairro foreign key(idbairro) references Bairro(idbairro)
);

select * from Endereco;