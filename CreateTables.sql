USE BLOCKBUSTER

CREATE TABLE AccType(
PlanID int NOT NULL PRIMARY KEY,
PlanName varchar(20),
PlanCost int,
PlanLimit  int)

CREATE TABLE Customer(
CustomerID int NOT NULL PRIMARY KEY,
FName char(80) NOT NULL,
LName char(80),
Email varchar(40),
Gender char(20),
Street varchar(20),
City varchar(40),
Province varchar(40),
ZipCode varchar(40),
CreationDate DATE,
ExpiryDate DATE,
CreditCardNo varchar,
PlanID int NOT NULL FOREIGN KEY REFERENCES AccType(PlanID),
Passwords varchar(40),
inHand int
)

CREATE TABLE Employee(
EmployeeID int NOT NULL PRIMARY KEY,
FName char(80) NOT NULL,
LName char(80),
Email varchar(40),
Gender char(20),
Street varchar(20),
City varchar(40),
Province varchar(40),
ZipCode varchar(40),
StartDate DATE,
Wage int,
Passwords varchar(40)
)


CREATE TABLE Movies(
MovieID int NOT NULL PRIMARY KEY,
Title varchar(80),
Genre varchar(80),
Fee int,
MovieRating int,
ReleaseYear int
)

CREATE TABLE Copies(
CopyID int NOT NULL,
MovieID int NOT NULL FOREIGN KEY REFERENCES Movies(MovieID),
CopyType char(20),
OrderStatus int,
Constraint PK_Copies primary key (CopyID, MovieID)
)


CREATE TABLE Actors(
ActorID int NOT NULL PRIMARY KEY,
FName varchar(80),
LName varchar(80),
Age int,
Gender char(20),
ActorRating int
)

CREATE TABLE Acts_In(
MovieID int NOT NULL FOREIGN KEY REFERENCES Movies(MovieID),
ActorsID int NOT NULL FOREIGN KEY REFERENCES Actors(ActorID),
ActorRating int,
Constraint PK_Acts_In primary key (MovieID, ActorsID))

drop table Orders;
CREATE TABLE Orders(
OrderID int NOT NULL PRIMARY KEY,
CustomerID int NOT NULL,
	
EmployeeID int NOT NULL,
CopyID int NOT NULL,
MovieID int NOT NULL,
DateFrom DATE,
DateTo DATE,
OrderStatus int,
Constraint FK_Copies 
FOREIGN KEY (CopyID, MovieID) REFERENCES Copies(CopyID, MovieID) ON DELETE NO ACTION ON UPDATE NO ACTION,
Constraint FK_Customer
FOREIGN KEY (CustomerID) REFERENCES Customer ON DELETE CASCADE ON UPDATE CASCADE,
Constraint FK_Employee
FOREIGN KEY (EmployeeID) REFERENCES Employee ON DELETE cascade ON UPDATE cascade
)

Insert into Orders values (1, 1, 1, 01, 1, '2008-11-11', '2008-11-30', 0);
Insert into Orders values (2, 1, 1, 01, 2, '2008-11-11', '2022-11-11', 0);
Insert into Orders values (3, 1, 1, 01, 3, '2008-11-11', '2008-11-30', 0);
Insert into Orders values (5, 3, 1, 01, 3, '2008-11-11', '2008-11-30', 0);

SELECT * FROM Orders
Insert Into Customer Values(3, 'Alexandra', 'Ferreira', 'alexF@macewan.ca', 'F', '10407 105 Ave NW', 'Edmonton', 'AB', 'T5J4S2', '2022-11-30', '2024-11-30', 01, 001, 'grumpy', 0);
delete from Customer where CustomerID = 3; 