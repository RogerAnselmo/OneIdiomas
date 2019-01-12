CREATE TABLE Cidade
(
	idcidade             INTEGER identity(1,1) NOT NULL,
	cdibge				 integer not null,
	dscidade             varchar(60) NOT NULL ,
	flativo              CHAR(1) NOT NULL ,
	iduf                 INTEGER not null,
	constraint XPKCidade primary key(idcidade),
	constraint XFKUF foreign key(iduf) references UF(iduf)
);


insert into cidade(cdibge,dscidade,iduf,flativo) values('1500107','Abaetetuba',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500131','Abel Figueiredo',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500206','Acar�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500305','Afu�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500347','�gua Azul do Norte',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500404','Alenquer',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500503','Almeirim',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500602','Altamira',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500701','Anaj�s',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500800','Ananindeua',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500859','Anapu',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500909','Augusto Corr�a',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1500958','Aurora do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501006','Aveiro',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501105','Bagre',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501204','Bai�o',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501253','Bannach',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501303','Barcarena',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501402','Bel�m',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501451','Belterra',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501501','Benevides',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501576','Bom Jesus do Tocan',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501600','Bonito',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501709','Bragan�a',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501725','Brasil Novo',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501758','Brejo Grande do Araguaia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501782','Breu Branco',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501808','Breves',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501907','Bujaru',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502004','Cachoeira do Arari',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1501956','Cachoeira do Piri�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502103','Camet�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502152','Cana� dos Caraj�s',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502202','Capanema',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502301','Capit�o Po�o',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502400','Castanhal',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502509','Chaves',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502608','Colares',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502707','Concei��o do Araguaia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502756','Conc�rdia do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502764','Cumaru do Norte',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502772','Curion�polis',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502806','Curralinho',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502855','Curu�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502905','Curu��',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502939','Dom Eliseu',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1502954','Eldorado dos Caraj�s',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503002','Faro',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503044','Floresta do Araguaia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503077','Garraf�o do Norte',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503093','Goian�sia do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503101','Gurup�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503200','Igarap�-A�u',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503309','Igarap�-Miri',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503408','Inhangapi',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503457','Ipixuna do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503507','Irituia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503606','Itaituba',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503705','Itupiranga',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503754','Jacareacanga',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503804','Jacund�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1503903','Juruti',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504000','Limoeiro do Ajuru',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504059','M�e do Rio',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504109','Magalh�es Barata',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504208','Marab�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504307','Maracan�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504406','Marapanim',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504422','Marituba',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504455','Medicil�ndia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504505','Melga�o',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504604','Mocajuba',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504703','Moju',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504802','Monte',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504901','Muan�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504950','Nova Esperan�a do Piri�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1504976','Nova Ipixuna',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505007','Nova Timboteua',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505031','Novo Progresso',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505064','Novo Repartimento',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505106','�bidos',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505205','Oeiras do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505304','Oriximin�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505403','Our�m',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505437','Ouril�ndia do Norte',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505486','Pacaj�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505494','Palestina do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505502','Paragominas',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505536','Parauapebas',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505551','Pau D',15,'A'); 
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505601','Peixe-Boi',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505635','Pi�arra',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505650','Placas',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505700','Ponta de Pedras',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505809','Portel',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1505908','Porto de Moz',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506005','Prainha',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506104','Primavera',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506112','Quatipuru',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506138','Reden��o',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506161','Rio Maria',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506187','Rondon do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506195','Rur�polis',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506203','Salin�polis',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506302','Salvaterra',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506351','Santa B�rbara do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506401','Santa Cruz do Arari',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506500','Santa Isabel do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506559','Santa Luzia do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506583','Santa Maria das Barreiras',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506609','Santa Maria do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506708','Santana do Araguaia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506807','Santar�m',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1506906','Santar�m Novo',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507003','Santo Ant�nio do Tau�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507102','S�o Caetano de Odivelas',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507151','S�o Domingos do Araguaia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507201','S�o Domingos do Capim',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507300','S�o F�lix do Xingu',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507409','S�o Francisco do Par�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507458','S�o Geraldo do Araguaia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507466','S�o Jo�o da Ponta',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507474','S�o Jo�o de Pirabas',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507508','S�o Jo�o do Araguaia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507607','S�o Miguel do Guam�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507706','S�o Sebasti�o da Boa',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507755','Sapucaia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507805','Senador Jos� Porf�rio',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507904','Soure',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507953','Tail�ndia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507961','Terra Alta',15,'A'); 
insert into cidade(cdibge,dscidade,iduf,flativo) values('1507979','Terra Santa',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508001','Tom�-A�u',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508035','Tracuateua',15,'A'); 
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508050','Trair�o',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508084','Tucum�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508100','Tucuru�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508126','Ulian�polis',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508159','Uruar�',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508209','Vigia',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508308','Viseu',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508357','Vit�ria do Xingu',15,'A');
insert into cidade(cdibge,dscidade,iduf,flativo) values('1508407','Xinguara',15,'A');