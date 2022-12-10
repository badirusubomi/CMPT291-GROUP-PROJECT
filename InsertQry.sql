USE BLOCKBUSTER

Insert Into AccType Values ( 001, 'Basic', 10, 2);
Insert Into AccType Values ( 002, 'Essential', 15, 999);
Insert Into AccType Values ( 003, 'Premium', 20, 999);
Insert Into AccType Values ( 004, 'Gold', 25, 999);

select max(OrderID) as maxID from Orders

Insert Into Customer Values(1, 'Mohamad', 'El-Hajj', 'elhajjm@macewan.ca', 'M', '10407 105 Ave NW', 'Edmonton', 'AB', 'T5J4S2', '2022-11-30', '2024-11-30', 01, 004, 'HalaMadrid', 0);
Insert Into Customer Values(2, 'Mohamad', 'El-Morsy', 'elmorsym@macewan.ca', 'M', '10407 105 Ave NW', 'Edmonton', 'AB', 'T5J4S2', '2022-11-30', '2024-11-30',01 , 004, 'NetworKING', 0);
Insert Into Customer Values(3, 'Alexandra', 'Ferreira', 'alexF@macewan.ca', 'F', '10407 105 Ave NW', 'Edmonton', 'AB', 'T5J4S2', '2022-11-30', '2024-11-30', 01, 001, 'grumpy', 0);

/* Altered credit card datatype*/
ALTER TABLE Customer
ALTER COLUMN CreditCardNo varchar(40);


insert into Employee values (1, 'Jerome','LName','jerome@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterJerome');
insert into Employee values (2, 'Olasubomi','Badiru','badiruo@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterOlasubomi');
insert into Employee values (3, 'Brandt','LName','brandt@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterBrandt');
insert into Employee values (4, 'Marek','LName','marek@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterMarek');

select * from Customer

insert into Movies values (1, 'The Incredibles', 'Action', 10, 5, 2019);
insert into Movies values (5, 'The Incredibles 2', 'Action', 10, 5, 2019);
insert into Movies values (2, 'Breaking Bad', 'Drama', 10, 5, 2017);
insert into Movies values (3, 'The Shining', 'Thriller', 7, 5, 2010);
insert into Movies values (4, 'DocumentaryUnit', 'Documentary', 2, 1, 2000);

Insert Into Actors values (1, 'Jack', 'Nicolson', 50, 'M',0);
Insert Into Actors values (2, 'Leonardo', 'DiCaprio', 50, 'M',0);
Insert Into Actors values (3, 'James', 'Franco', 40, 'M',0);
Insert Into Actors values (4, 'Seth', 'Rogan', 46, 'M',0);
Insert Into Actors values (5, 'Kate', 'Winslet', 47, 'F',0);
Insert Into Actors values (6, 'Brian', 'Cranston', 60, 'M',0);
Insert Into Actors values (7, 'Daniel', 'Craig', 70, 'M',0);

Insert into Acts_In values (3, 1, 0);
Insert into Acts_In values (2, 6, 0);

/*For OrderStatus 0 = Out; 1 = InStock; 2 = Late*/
Insert into Copies values (01, 1, 'DVD', 1);
Insert into Copies values (02, 1, 'Blu-Ray', 1);
Insert into Copies values (03, 1, 'VHS', 1);
Insert into Copies values (01, 2, 'DVD', 1);
Insert into Copies values (02, 2, 'Blu-Ray', 1);
Insert into Copies values (03, 2, 'VHS', 1);
Insert into Copies values (01, 3, 'DVD', 1);
Insert into Copies values (02, 3, 'Blu-Ray', 1);
Insert into Copies values (03, 3, 'VHS', 1);
Insert into Copies values (01, 4, 'DVD', 1);
Insert into Copies values (02, 4, 'Blu-Ray', 1);
Insert into Copies values (03, 4, 'VHS', 1);
Insert into Copies values (01, 5, 'DVD', 1);
Insert into Copies values (02, 5, 'Blu-Ray', 1);
Insert into Copies values (03, 5, 'VHS', 1);


Insert into Orders values (1, 1, 1, 01, 1, '2008-11-11', '2008-11-30', 0);
Insert into Orders values (2, 1, 1, 01, 2, '2008-11-11', '2022-11-11', 0);
Insert into Orders values (3, 1, 1, 01, 3, '2008-11-11', '2008-11-30', 0);

select * from Orders;
select Customer.CustomerID as ID from Customer where Customer.email = 'elhajjm@macewan.ca'
select * from Orders, Movies where Orders.MovieID = Movies.MovieID and Orders.CustomerID = 1;

UPDATE Customer SET inHand = inHand + 1 where Customer.CustomerID = 1;
select * from Customer

select * from Employee
select * from Orders;
select C1.CopyID, C1.MovieID from Copies as C1, Orders as O1 where C1.MovieID = O1.MovieID and O1.CopyID = C1.CopyID and  O1.MovieID = 1
EXCEPT
(select C2.CopyID, C2.MovieID from Copies as C2, Orders as O2 where C2.MovieID = O2.MovieID and O2.CopyID = C2.CopyID and  O2.MovieID = 1
and C2.MovieID = 1 and O2.Datefrom >= '2022-12-12' and O2.Dateto <= '2022-12-16');

select * from Copies where MovieID = 1;
select * from Orders where MovieID = 1;

select *, Concat(C7.CopyID,C7.MovieID) as uniquekey from Copies as C7, (select * from Movies as M1 where M1.MovieID = 1) as temp where C7.MovieID = temp.MovieID
and Concat(C7.CopyID,C7.MovieID) not in  (select Concat(C8.CopyID,C8.MovieID) from Copies as C8, 
Orders as O2 where O2.CopyID = C8.CopyID and  O2.MovieID = C8.MovieID  and C8.CopyID = C7.CopyID and C8.MovieID = C7.MovieID 
and O2.DateTo <= '2008-12-9')

/*
UPDATE Employee

SET EmployeeID = {}, FName = {}, LName = {}, Email = {}, Gender = {},
	Street = {}, City = {}, Province = {}, ZipCode = {}, StartDate = {},
	Wage = {}, Passwords = {}
WHERE CustomerID = {};



select * from Customer;
UPDATE Employee SET EmployeeID = {employeeIDEdit.Text}, FName = '{employeeEditFNameLabel.Text}', LName = '{employeeEditLNameLabel.Text}', Email = '{employeeEditEmailLabel.Text}',
                                            Gender = '{employeeEditGenderLabel.Text}', Street = '{employeeEditStreetLabel.Text}',
                                            City = '{employeeEditCityLabel.Text}', Province = '{employeeEditStateLabel.Text}', 
                                            ZipCode = '{employeeEditPostalLabel.Text}',Wage = {employeeEditWageLabel.Text},
                                            Passwords = '{employeeEditPasswordLabel.Text}' WHERE EmployeeID = {employeeIDEdit.Text};
*/

select * from Orders
delete  from Orders where Orders.OrderID >=4;

UPDATE CUSTOMER SET 
Passwords = 'HalaMadrid' WHERE CustomerID = 1;


delete Movies;
delete Copies;
delete Customer;
delete Orders;


/*   Marek Insertion Queries  */

insert into  AccType values (1, 'Basic', 10, 2);
insert into  AccType values (2, 'Essential', 15, 5);
insert into  AccType values (3, 'Premium', 20,10);

insert into Movies values (1, 'Spider-Man', 'Action', 10,9, 2002);
insert into Movies values (2, 'Spider-Man 2', 'Action', 10,9, 2004);
insert into Movies values (3, 'Spider-Man 3', 'Thriller', 10,6, 2007);
insert into Movies values (4, 'Harry Potter and the Philosophers Stone', 'Documentary', 10,9, 2001);
insert into Movies values (5, 'Harry Potter and the Chamber of Secrets', 'Documentary', 10,8, 2002);
insert into Movies values (6, 'Harry Potter and the Prisoner of Azkaban', 'Documentary', 10,10, 2004);
insert into Movies values (7, 'Harry Potter and the Goblet of Fire', 'Thriller', 10,7, 2005);
insert into Movies values (8, 'Harry Potter and the Order of the Phoenix', 'Drama', 10,8, 2007);
insert into Movies values (9, 'Harry Potter and the Half-Blood Prince', 'Drama', 10,8, 2009);
insert into Movies values (10, 'Harry Potter and the Deatly Hallows - Part 1', 'Drama', 10,7, 2010);
insert into Movies values (11, 'Harry Potter and the Deatly Hallows - Part 2', 'Drama', 10,9, 2011);
insert into Movies values (12, 'The Great Gatsby', 'Documentary', 10,10, 2013);
insert into Movies values (13, 'Iron Man', 'Thriller', 10,9, 2008);
insert into Movies values (14, 'Iron Man 2', 'Thriller', 10,7, 2010);
insert into Movies values (15, 'Iron Man 3', 'Action', 10,4, 2013);
insert into Movies values (16, 'Pirates of the Caribbean: The Curse of the Black Pearl', 'Action', 10,9, 2003);
insert into Movies values (17, 'Pirates of the Caribbean: Dead Mans Chest', 'Action', 10,8, 2006);
insert into Movies values (18, 'Pirates of the Caribbean: At Worlds End', 'Action', 10,7, 2007);
insert into Movies values (19, 'Pirates of the Caribbean: On Stranger Tides', 'Action', 10,6, 2011);
insert into Movies values (20, 'Pirates of the Caribbean: Dead Men Tell No Tales', 'Action', 10,8, 2079);


insert into Copies values (1, 1, 'DVD', 1);
insert into Copies values (2, 1, 'Blu-Ray', 1);
insert into Copies values (3, 1, 'VHS', 1);
insert into Copies values (1, 2, 'DVD', 1);
insert into Copies values (2, 2, 'Blu-Ray', 1);
insert into Copies values (3, 2, 'VHS', 1);
insert into Copies values (1, 3, 'DVD', 1);
insert into Copies values (2, 3, 'Blu-Ray', 1);
insert into Copies values (3, 3, 'VHS', 1);
insert into Copies values (1, 4, 'DVD', 1);
insert into Copies values (2, 4, 'Blu-Ray', 1);
insert into Copies values (3, 4, 'VHS', 1);
insert into Copies values (1, 5, 'DVD', 1);
insert into Copies values (2, 5, 'Blu-Ray', 1);
insert into Copies values (3, 5, 'VHS', 1);
insert into Copies values (1, 6, 'DVD', 1);
insert into Copies values (2, 6, 'Blu-Ray', 1);
insert into Copies values (3, 6, 'VHS', 1);
insert into Copies values (1, 7, 'DVD', 1);
insert into Copies values (2, 7, 'Blu-Ray', 1);
insert into Copies values (3, 7, 'VHS', 1);
insert into Copies values (1, 8, 'DVD', 1);
insert into Copies values (2, 8, 'Blu-Ray', 1);
insert into Copies values (3, 8, 'VHS', 1);
insert into Copies values (1, 9, 'DVD', 1);
insert into Copies values (2, 9, 'Blu-Ray', 1);
insert into Copies values (3, 9, 'VHS', 1);
insert into Copies values (1, 10, 'DVD', 1);
insert into Copies values (2, 10, 'Blu-Ray', 1);
insert into Copies values (3, 10, 'VHS', 1);
insert into Copies values (1, 11, 'DVD', 1);
insert into Copies values (2, 11, 'Blu-Ray', 1);
insert into Copies values (3, 11, 'VHS', 1);
insert into Copies values (1, 12, 'DVD', 1);
insert into Copies values (2, 12, 'Blu-Ray', 1);
insert into Copies values (3, 12, 'VHS', 1);
insert into Copies values (1, 13, 'DVD', 1);
insert into Copies values (2, 13, 'Blu-Ray', 1);
insert into Copies values (3, 13, 'VHS', 1);
insert into Copies values (1, 14, 'DVD', 1);
insert into Copies values (2, 14, 'Blu-Ray', 1);
insert into Copies values (3, 14, 'VHS', 1);
insert into Copies values (1, 15, 'DVD', 1);
insert into Copies values (2, 15, 'Blu-Ray', 1);
insert into Copies values (3, 15, 'VHS', 1);
insert into Copies values (1, 16, 'DVD', 1);
insert into Copies values (2, 16, 'Blu-Ray', 1);
insert into Copies values (3, 16, 'VHS', 1);
insert into Copies values (1, 17, 'DVD', 1);
insert into Copies values (2, 17, 'Blu-Ray', 1);
insert into Copies values (3, 17, 'VHS', 1);
insert into Copies values (1, 18, 'DVD', 1);
insert into Copies values (2, 18, 'Blu-Ray', 1);
insert into Copies values (3, 18, 'VHS', 1);
insert into Copies values (1, 19, 'DVD', 1);
insert into Copies values (2, 19, 'Blu-Ray', 1);
insert into Copies values (3, 19, 'VHS', 1);
insert into Copies values (1, 20, 'DVD', 1);
insert into Copies values (2, 20, 'Blu-Ray', 1);
insert into Copies values (3, 20, 'VHS', 1);

insert into Customer values (1,'Mohamad','ElHajj','elhajjm@macewan.ca','M','MacEwan Residence', 'Edmonton','Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283490, 1,'HalaMadrid',0);
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

insert into Employee values (1, 'Jerome','Onil','jeromeo@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 27000, 'BlockbusterJerome');
insert into Employee values (2, 'Olasubomi','Badiru','badiruo@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 1, 'BlockbusterOlasubomi');
insert into Employee values (3, 'Brandt','Sanche','brandtc@mymacewan.ca','M','MacEwan Residence', 'Edmonton', 'Alberta', 'T6V0L5', '2022-01-01', 23000, 'BlockbusterBrandt');
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
