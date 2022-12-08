USE BLOCKBUSTER

Insert Into AccType Values ( 001, 'Basic', 10, 2);
Insert Into AccType Values ( 002, 'Essential', 15, 999);
Insert Into AccType Values ( 003, 'Premium', 20, 999);
Insert Into AccType Values ( 004, 'Gold', 25, 999);


Insert Into Customer Values(1, 'Mohamad', 'El-Hajj', 'elhajjm@macewan.ca', 'M', '10407 105 Ave NW', 'Edmonton', 'AB', 'T5J4S2', '2022-11-30', '2024-11-30', 01, 004, 'HalaMadrid', 0);
Insert Into Customer Values(2, 'Mohamad', 'El-Morsy', 'elmorsym@macewan.ca', 'M', '10407 105 Ave NW', 'Edmonton', 'AB', 'T5J4S2', '2022-11-30', '2024-11-30',01 , 004, 'NetworKING', 0);
Insert Into Customer Values(3, 'Alexandra', 'Ferreira', 'alexF@macewan.ca', 'F', '10407 105 Ave NW', 'Edmonton', 'AB', 'T5J4S2', '2022-11-30', '2024-11-30', 01, 001, 'grumpy', 0);


insert into Employee values (1, 'Jerome','LName','jerome@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterJerome');
insert into Employee values (2, 'Olasubomi','Badiru','badiruo@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterOlasubomi');
insert into Employee values (3, 'Brandt','LName','brandt@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterBrandt');
insert into Employee values (4, 'Marek','LName','marek@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterMarek');


insert into Movies values (1, 'The Incredibles', 'Action', 10,2019, 5);
insert into Movies values (5, 'The Incredibles 2', 'Action', 10, 2019, 5);
insert into Movies values (2, 'Breaking Bad', 'Drama', 10, 2017,5);
insert into Movies values (3, 'The Shining', 'Thriller', 7, 2010, 5);
insert into Movies values (4, 'DocumentaryUnit', 'Documentary', 2, 2000, 1);

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
Passwords = 'HalaMadrid' WHERE CustomerID = 1