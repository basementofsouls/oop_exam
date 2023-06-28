create database Goods;

create table Goods(
	good_id int PRIMARY KEY,
	good_name nvarchar(50),
	good_year int
	);

insert into Goods
	values(1, 'good1', 2008);
	insert into Goods
	values(2, 'good2', 2009);
	insert into Goods
	values(3, 'good3', 2010);
	insert into Goods
	values(4, 'good4', 2010);