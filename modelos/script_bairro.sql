CREATE TABLE Bairro
(
	idbairro             integer NOT NULL identity(1,1) ,
	dsbairro             VARCHAR(60) NOT NULL ,
	flativo              CHAR(1) NOT NULL ,
	idcidade             INTEGER NOT NULL,
	constraint XPKBairro primary key(idbairro),
	constraint XFKCidade foreign key(idcidade) references Cidade(idcidade)
);

insert into Bairro values ('Centro', 'A', 1);
insert into Bairro values ('Algodoal', 'A', 1);
insert into Bairro values ('Nazaré', 'A', 1);
insert into Bairro values ('Francilândia', 'A', 1);
insert into Bairro values ('Cristo Redentor', 'A', 1);
insert into Bairro values ('São Lourenço', 'A', 1);
insert into Bairro values ('Santa Rosa', 'A', 1);
insert into Bairro values ('Aviação', 'A', 1);
insert into Bairro values ('São Sebastião', 'A', 1);
insert into Bairro values ('Angélica', 'A', 1);
insert into Bairro values ('Colõnia Nova', 'A', 1);
insert into Bairro values ('Colônia Velha', 'A', 1);

select * from Bairro