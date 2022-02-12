  create table CarImages(
    Id int not null,
    CarId int not null,
    ImagePath nvarchar(100)null,
    Date DateTime null,
    primary key(Id),
    CONSTRAINT FK_CarImages_CarId FOREIGN KEY(CarId) REFERENCES Cars(Id)



    )