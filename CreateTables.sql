USE [BLOCKBUSTER]

CREATE TABLE AccType(
PlanID int NOT NULL PRIMARY KEY,
PlanName varchar(20),
PlanCost int,
PlanLimit  int)

CREATE TABLE Customer(
CustomerID int NOT NULL PRIMARY KEY,
FName char(80) NOT NULL,
LName char(80),
email varchar(40),
Gender char(20),
Street varchar(20),
City varchar(40),
Province varchar(40),
ZipCode varchar(40),
CreationDate DATE,
ExpiryDate DATE,
CreditCardNo int,
PlanID int NOT NULL FOREIGN KEY REFERENCES AccType(PlanID),
Passwords varchar(40)
)

CREATE TABLE Employee(
EmployeeID int NOT NULL PRIMARY KEY,
FName char(80) NOT NULL,
LName char(80),
email varchar(40),
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
Year int,
MovieRating int
)

CREATE TABLE Copies(
CopyID int NOT NULL PRIMARY KEY,
MovieID int NOT NULL FOREIGN KEY REFERENCES Movies(MovieID),
CopyType char(20)
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
ActorRating int)

CREATE TABLE Orders(
OrderID int NOT NULL PRIMARY KEY,
CustomerID int NOT NULL FOREIGN KEY REFERENCES Customer(CustomerID),
EmployeeID int NOT NULL FOREIGN KEY REFERENCES Employee(EmployeeID),
CopyID int NOT NULL FOREIGN KEY REFERENCES Copies(CopyID),
MovieID int NOT NULL FOREIGN KEY REFERENCES Movies(MovieID),
DateFrom DATE,
DateTo DATE)
