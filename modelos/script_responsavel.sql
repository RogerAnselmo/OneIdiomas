CREATE TABLE GAResponsavel(

idresponsavel  INTEGER identity(1,1) NOT NULL,
nomecompleto VARCHAR(200) NOT NULL ,
nrcpf VARCHAR(11) NOT NULL ,
flativo CHAR(1) NOT NULL,
constraint XPKGAIdioma primary key(ididioma)

);