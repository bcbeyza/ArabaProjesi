create table Rentals(


Id int not null,
CarId int not null,
CustomerId int not null,
RentDate int not null,
ReturnDate int 
primary key(Id)

)

create table Customers(

UserId int not null,
CompanyName nvarchar(30) not null
primary key(UserId)
CONSTRAINT _FK_Customers_UserId FOREIGN KEY (UserId) REFERENCES Users(Id)
)

create table Users(

Id int not null,
FirstName nvarchar(20)not null,
LastName nvarchar(20)not null,
Email nvarchar(30)not null,
Password nvarchar(30)not null
primary key(Id)

)
--CONSTRAINT [FK_Cars_Brand] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brand] ([Id]),
--CONSTRAINT _FK_Users_Id FOREIGN KEY (Id) REFERENCES Customers()