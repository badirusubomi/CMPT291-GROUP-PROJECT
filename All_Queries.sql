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
CopyID int NOT NULL PRIMARY KEY,
MovieID int NOT NULL FOREIGN KEY REFERENCES Movies(MovieID),
CopyType char(20),
OrderStatus int
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
DateTo DATE,
OrderStatus int)




















insert into Movies values (1, 'Spider-Man', 'Action', 10,9, 2002);
insert into Movies values (2, 'Spider-Man 2', 'Action', 10,9, 2004);
insert into Movies values (3, 'Spider-Man 3', 'Action', 10,6, 2007);
insert into Movies values (4, 'Harry Potter and the Philosophers Stone', 'Fantasy', 10,9, 2001);
insert into Movies values (5, 'Harry Potter and the Chamber of Secrets', 'Fantasy', 10,8, 2002);
insert into Movies values (6, 'Harry Potter and the Prisoner of Azkaban', 'Fantasy', 10,10, 2004);
insert into Movies values (7, 'Harry Potter and the Goblet of Fire', 'Fantasy', 10,7, 2005);
insert into Movies values (8, 'Harry Potter and the Order of the Phoenix', 'Fantasy', 10,8, 2007);
insert into Movies values (9, 'Harry Potter and the Half-Blood Prince', 'Fantasy', 10,8, 2009);
insert into Movies values (10, 'Harry Potter and the Deatly Hallows - Part 1', 'Fantasy', 10,7, 2010);
insert into Movies values (11, 'Harry Potter and the Deatly Hallows - Part 2', 'Fantasy', 10,9, 2011);
insert into Movies values (12, 'The Great Gatsby', 'Tradgedy', 10,10, 2013);
insert into Movies values (13, 'Iron Man', 'Action', 10,9, 2008);
insert into Movies values (14, 'Iron Man 2', 'Action', 10,7, 2010);
insert into Movies values (15, 'Iron Man 3', 'Action', 10,4, 2013);
insert into Movies values (16, 'Pirates of the Caribbean: The Curse of the Black Pearl', 'Action', 10,9, 2003);
insert into Movies values (17, 'Pirates of the Caribbean: Dead Mans Chest', 'Action', 10,8, 2006);
insert into Movies values (18, 'Pirates of the Caribbean: At Worlds End', 'Action', 10,7, 2007);
insert into Movies values (19, 'Pirates of the Caribbean: On Stranger Tides', 'Action', 10,6, 2011);
insert into Movies values (20, 'Pirates of the Caribbean: Dead Men Tell No Tales', 'Action', 10,8, 2079);


insert into Copies values (1, 1, 'DVD', 1);
insert into Copies values (2, 1, 'Blu-Ray', 1);
insert into Copies values (3, 1, 'VHS', 1);
insert into Copies values (4, 2, 'DVD', 1);
insert into Copies values (5, 2, 'Blu-Ray', 1);
insert into Copies values (6, 2, 'VHS', 1);
insert into Copies values (7, 3, 'DVD', 1);
insert into Copies values (8, 3, 'Blu-Ray', 1);
insert into Copies values (9, 3, 'VHS', 1);
insert into Copies values (10, 4, 'DVD', 1);
insert into Copies values (11, 4, 'Blu-Ray', 1);
insert into Copies values (12, 4, 'VHS', 1);
insert into Copies values (13, 5, 'DVD', 1);
insert into Copies values (14, 5, 'Blu-Ray', 1);
insert into Copies values (15, 5, 'VHS', 1);
insert into Copies values (16, 6, 'DVD', 1);
insert into Copies values (17, 6, 'Blu-Ray', 1);
insert into Copies values (18, 6, 'VHS', 1);
insert into Copies values (19, 7, 'DVD', 1);
insert into Copies values (20, 7, 'Blu-Ray', 1);
insert into Copies values (21, 7, 'VHS', 1);
insert into Copies values (22, 8, 'DVD', 1);
insert into Copies values (23, 8, 'Blu-Ray', 1);
insert into Copies values (24, 8, 'VHS', 1);
insert into Copies values (25, 9, 'DVD', 1);
insert into Copies values (26, 9, 'Blu-Ray', 1);
insert into Copies values (27, 9, 'VHS', 1);
insert into Copies values (28, 10, 'DVD', 1);
insert into Copies values (29, 10, 'Blu-Ray', 1);
insert into Copies values (30, 10, 'VHS', 1);
insert into Copies values (31, 11, 'DVD', 1);
insert into Copies values (32, 11, 'Blu-Ray', 1);
insert into Copies values (33, 11, 'VHS', 1);
insert into Copies values (34, 12, 'DVD', 1);
insert into Copies values (35, 12, 'Blu-Ray', 1);
insert into Copies values (36, 12, 'VHS', 1);
insert into Copies values (37, 13, 'DVD', 1);
insert into Copies values (38, 13, 'Blu-Ray', 1);
insert into Copies values (39, 13, 'VHS', 1);
insert into Copies values (40, 14, 'DVD', 1);
insert into Copies values (41, 14, 'Blu-Ray', 1);
insert into Copies values (42, 14, 'VHS', 1);
insert into Copies values (43, 15, 'DVD', 1);
insert into Copies values (44, 15, 'Blu-Ray', 1);
insert into Copies values (45, 15, 'VHS', 1);
insert into Copies values (46, 16, 'DVD', 1);
insert into Copies values (47, 16, 'Blu-Ray', 1);
insert into Copies values (48, 16, 'VHS', 1);
insert into Copies values (49, 17, 'DVD', 1);
insert into Copies values (50, 17, 'Blu-Ray', 1);
insert into Copies values (51, 17, 'VHS', 1);
insert into Copies values (52, 18, 'DVD', 1);
insert into Copies values (53, 18, 'Blu-Ray', 1);
insert into Copies values (54, 18, 'VHS', 1);
insert into Copies values (55, 19, 'DVD', 1);
insert into Copies values (56, 19, 'Blu-Ray', 1);
insert into Copies values (57, 19, 'VHS', 1);
insert into Copies values (58, 20, 'DVD', 1);
insert into Copies values (59, 20, 'Blu-Ray', 1);
insert into Copies values (60, 20, 'VHS', 1);


insert into Customer values (1,'Mohammed','ElHajj','mohammedE@mymacewan.ca','M','MacEwan Residence', 'Edmonton','Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283490, 1,'password',0);
insert into Customer values (2,'Luc','Blanchette','lucb@mymacewan.ca','M','123 Street', 'Falher','Alberta', 'T0H 1G0', '2022-01-01', '2023-01-01',30283491, 2,'password',0);
insert into Customer values (3,'Kirk','Desharnais','kirk@mymacewan.ca','M','124 Street', 'Falher','Alberta', 'T0H 1G0', '2022-01-01', '2023-01-01',30283491, 3,'password',0);
insert into Customer values (4,'Dylan','Desharnais','dyland@mymacewan.ca','M','125 Street', 'Falher','Alberta', 'T0H 1G0', '2022-01-01', '2023-01-01',30283491, 2,'password',0);
insert into Customer values (5,'Logan','Yaremko','logany@mymacewan.ca','M','126 Street', 'Falher','Alberta', 'T0H 1G0', '2022-01-01', '2023-01-01',30283491, 1,'password',0);
insert into Customer values (6,'Paul','Dubois','pauld@mymacewan.ca','M','127 Street', 'Falher','Alberta', 'T0H 1G0', '2022-01-01', '2023-01-01',30283491, 1,'password',0);
insert into Customer values (7,'Kaitlyn','St.Laurent','kaitlyns@mymacewan.ca','F','128 Street', 'Falher','Alberta', 'T0H 1G0', '2022-01-01', '2023-01-01',30283491, 3,'password',0);
insert into Customer values (8,'Makenna','Maisonneuve','makennam@mymacewan.ca','F','129 Street', 'Falher','Alberta', 'T0H 1G0', '2022-01-01', '2023-01-01',30283491, 1,'BlockbusterLuc',0);
insert into Customer values (9,'Mohammed','ElHajj','mohammed@mymacewan.ca','M','MacEwan Residence', 'Edmonton','Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283498, 3,'password',0);
insert into Customer values (10,'Claire','White','clairew@mymacewan.ca','F','MacEwan Residence', 'Edmonton','Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283499, 2,'password',0);
insert into Customer values (11,'Walter','Grey','walterg@mymacewan.ca','M','MacEwan Residence', 'Edmonton','Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283410, 1,'password',0);
insert into Customer values (12,'Jesse','Purpleman','jessep@mymacewan.ca','M','MacEwan Residence', 'Edmonton','Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283411, 2,'password',0);
insert into Customer values (13,'Mike','Trout','miket@mymacewan.ca','M','MacEwan Residence', 'Edmonton','Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283412, 1,'password',0);
insert into Customer values (14,'Saul','Decentman','sauld@mymacewan.ca','M','MacEwan Residence', 'Edmonton','Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283413, 1,'password',0);
insert into Customer values (15,'Gustavo','Ping','gustavop@mymacewan.ca','M','Olivier Street', 'Edmonton','Alberta', 'T5N3X1', '2022-01-01', '2023-01-01',30283414, 3,'password',0);
insert into Customer values (16,'Bianca','Brulotte','biancab@mymacewan.ca','F','Olivier Street', 'Edmonton','Alberta', 'T5N3X1', '2022-01-01', '2023-01-01',30283415, 3,'password',0);
insert into Customer values (17,'Stella','Anderson','stellaa@mymacewan.ca','F','Olivier Street', 'Edmonton','Alberta', 'T5N3X1', '2022-01-01', '2023-01-01',30283416, 2,'password',0);
insert into Customer values (18,'Christa','Elos','christae@mymacewan.ca','F','Olivier Street', 'Edmonton','Alberta', 'T5N3X1', '2022-01-01', '2023-01-01',30283417, 1,'password',0);
insert into Customer values (19,'Ethan','Kepler','ethank@mymacewan.ca','M','Olivier Street', 'Edmonton','Alberta', 'T5N3X1', '2022-01-01', '2023-01-01',30283418, 1,'password',0);
insert into Customer values (20,'Zack','Nator','zackn@mymacewan.ca','M','Olivier Street', 'Edmonton','Alberta', 'T5N3X1', '2022-01-01', '2023-01-01',30283419, 2,'password',0);


insert into Employee values (1, 'Jerome','Steel','jeromes@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 27000, 'BlockbusterJerome');
insert into Employee values (2, 'Olasubomi','Badiru','badiruo@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 30000, 'BlockbusterOlasubomi');
insert into Employee values (3, 'Brandt','Cleen','brandtc@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 23000, 'BlockbusterBrandt');
insert into Employee values (4, 'Marek','Maisonneuve','marekm@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 20000, 'BlockbusterMarek');
insert into Employee values (5, 'Luke','Forg','lukef@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterLuke');
insert into Employee values (6, 'Trey','Porku','treyp@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 15000, 'BlockbusterTrey');
insert into Employee values (7, 'Sam','Reinhart','samr@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 16000, 'BlockbusterSam');
insert into Employee values (8, 'Miko','Zibenejad','mikoz@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 18000, 'BlockbusterMiko');
insert into Employee values (9, 'Darcy','Kuemper','darcyk@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 19000, 'BlockbusterDarcy');
insert into Employee values (10, 'Igor','Shesterkin','igors@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterIgor');
insert into Employee values (11, 'Sidney','Crosby','sidneyc@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterSidney');
insert into Employee values (12, 'Jake','Oettinger','jakeo@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 12000, 'BlockbusterJake');
insert into Employee values (13, 'Lesslie','Snipes','lesslies@mymacewan.ca','F','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 13000, 'BlockbusterLesslie');
insert into Employee values (14, 'Penny','White','pennyw@mymacewan.ca','F','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 14000, 'BlockbusterPenny');
insert into Employee values (15, 'Serelle','Iotin','serellei@mymacewan.ca','F','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 19000, 'BlockbusterSerelle');

/* Customers with multiple orders*/
SELECT DISTINCT C.CustomerID, C.FName, C.LName
FROM Customer AS C
WHERE C.CustomerID IN 
(SELECT CID
FROM 
(SELECT O.CustomerID AS CID, O.MovieID 
FROM Orders AS O
GROUP BY O.CustomerID, O.MovieID
HAVING COUNT(*) > 1) AS Customers_With_Multiple_Orders)

/*Most Ordered Movie */
SELECT DISTINCT M.MovieID, M.Title, COUNT(*) AS Times_Ordered
FROM Movies AS M, 
Orders AS O
WHERE M.MovieID = O.MovieID
GROUP BY M.MovieID, M.Title
HAVING COUNT(*) = 
(SELECT MAX(Order_Count)
FROM 
(SELECT M2.MovieID, COUNT(M2.MovieID) AS Order_Count 
FROM Movies AS M2, 
Orders AS O2 
WHERE M2.MovieID = O2.MovieID 
GROUP BY M2.MovieID) AS Max_Order_Count)

/*Customers with most orders*/
SELECT C.CustomerID, C.FName, C.LName, COUNT(*) AS Orders_Placed
FROM Orders AS O, 
Customer AS C
WHERE O.CustomerID = C.CustomerID
GROUP BY C.CustomerID, C.FName, C.LName
HAVING COUNT(*) = 
(SELECT MAX(Order_Count)
FROM 
(SELECT C2.CustomerID, COUNT(C2.CustomerID) AS Order_Count 
FROM Orders AS O2, 
Customer AS C2 
WHERE O2.CustomerID = C2.CustomerID
GROUP BY C2.CustomerID) AS Max_Order_Count)


	/*Most Rented Movie of the moive/year */
select max(Rentals), M.Title from
(	select count(*) as Rentals, MovieID 
	from Orders
	where Month(DateFrom) = <month> or  Year(DateFrom) = year
	group by MoiveID) as Temp1, Movies as M
	where Temp1.MovieID = M.MovieID;
	

	/*Most Rented Format (DVD,VHS ...)*/
	select max(Rentals), C.CopyType
	from ( select count(*) as Rentals, MovieID , CopyID
	from Orders
	where Month(DateFrom) = <month> or  Year(DateFrom) = year
	group by MovieID , CopyID) as Temp1, Copies as C
	where Temp1.MovieID = C.MovieID and Temp1.CopyID = C.CopyID;

	/*Employee with most transactions*/
	select count(*) as Sales, EmployeeID
	from Orders
	where Month(DateFrom) = <month>
	group by EmployeeID

	/*Most popular plan*/
	select PlanName, Subscriptions 
	from (select count(*) as Subscriptions, PLanID 
	from Customer
	group by PlanID) as T, AccType as A
	where T.PlanID = A.PlanID 

	/*Overdue Movies*/
	select CustomerID, MovieID, CopyID
	from Orders
	where OrderStatus = 2