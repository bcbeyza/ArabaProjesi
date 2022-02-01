---create table Cars(
--CarId int not null,
--BrandId int not null,
--ColorId int not null,
--CarName nvarchar(20) not null,
--Description nvarchar(20) not null,
--DailyPrice int not null,
--ModelYear nvarchar(10) not null)


create table Colors(
ColorId int not null,
ColorName nvarchar(20) not null)

insert into Colors(ColorId,ColorName)values(1,'Black')
insert into Colors(ColorId,ColorName)values(2,'Red')
insert into Colors(ColorId,ColorName)values(3,'White')

create table Brands(
BrandId int not null,
BrandName nvarchar(20)not null)

insert into Brands(BrandId,BrandName)values(1,'Range Rover')
insert into Brands(BrandId,BrandName)values(2,'Land Rover')
insert into Brands(BrandId,BrandName)values(3,'Lamborghini')


insert into Cars(CarId,BrandId,ColorId,CarName,Description,DailyPrice,ModelYear)
values (1,1,1,'Range Rover 2019','New Model',700,'2019')

insert into Cars(CarId,BrandId,ColorId,CarName,Description,DailyPrice,ModelYear)
values (2,2,2,'Land Rover 2017','Secondhand Car',500,'2017')

insert into Cars(CarId,BrandId,ColorId,CarName,Description,DailyPrice,ModelYear)
values (3,3,3,'Lamborghini 2021','New Model',2000,'2021')


