create table Cars(

Id int not null,
BrandId int not null,
ColorId int not null,
DailyPrice int not null,
ModelYear nvarchar(20) not null,
CarName nvarchar(20) not null,
Description nvarchar(20) not null
primary key(Id),

--CONSTRAINT fk_Cars_Brand FOREIGN KEY(BrandId) REFERENCES Brands(Id)


)



create table Colors(

Id int not null,
ColorName nvarchar(20) not null
primary key(Id)


)

create table Brands(

Id int not null,
BrandName nvarchar(20) not null,
primary key(Id)


)

insert into Brands(Id,BrandName)values(1,'Range Rover')
insert into Brands(Id,BrandName)values(2,'Land Rover')
insert into Brands(Id,BrandName)values(3,'Lamborghini')

insert into Colors(Id,ColorName)values(1,'Black')
insert into Colors(Id,ColorName)values(2,'Red')
insert into Colors(Id,ColorName)values(3,'White')

insert into Cars(Id,BrandId,ColorId,CarName,Description,DailyPrice,ModelYear)
values (1,1,1,'Range Rover 2019','New Model',700,'2019')

insert into Cars(Id,BrandId,ColorId,CarName,Description,DailyPrice,ModelYear)
values (2,2,2,'Land Rover 2017','Secondhand Car',500,'2017')

insert into Cars(Id,BrandId,ColorId,CarName,Description,DailyPrice,ModelYear)
values (3,3,3,'Lamborghini 2021','New Model',2000,'2021')