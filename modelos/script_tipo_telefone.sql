use one;

create table TipoTelefone(
idTipoTelefone int identity(1,1),
dsTipoTelefone varchar(20) not null,
flAtivo varchar(1) not null
);

insert into TipoTelefone values('Celualar', 'A');
insert into TipoTelefone values('Residencial', 'A');
insert into TipoTelefone values('Outro', 'A');