CREATE TABLE GAIdioma
(
	ididioma                 INTEGER identity(1,1) NOT NULL,
	dsidioma                 VARCHAR(20) NOT NULL ,
	dssiglaidioma            CHAR(3) NOT NULL ,
	flativo              CHAR(1) NOT NULL,
	constraint XPKGAIdioma primary key(ididioma)
);

insert into gaidioma(dsidioma,dssiglaidioma,flativo) values('Ingês','ING','A');
insert into gaidioma(dsidioma,dssiglaidioma,flativo) values('Espanhol','ESP','A');