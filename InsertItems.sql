
/*		DATE format: YYYY-MM-DD		*/

USE [BLOCKBUSTER]


/*		Inserting into Account Type(PlanID, PlanName, PlanCost, PlanLimit)	*/
insert into  AccType values (1, 'Basic', 10, 2);
insert into  AccType values (2, 'Essential', 15, 5);
insert into  AccType values (3, 'Premium', 20,10);

/*		Inserting into Movies	*/
insert into Movies values (21, 'The Incredibles', 'Action', 10,5, 2019);
insert into Movies values (25, 'The Incredibles 2', 'Comedy', 10, 5,2019);
insert into Movies values (22, 'Breaking Bad', 'Drama', 10, 5,2017);
insert into Movies values (23, 'The Shining', 'Thriller', 7, 5, 2010);
insert into Movies values (24, 'DocumentaryUnit', 'Documentary', 2, 1, 2000);

/*		Inserting into Movies	*/
insert into Movies values (1, 'The Incredibles', 'Action', 10,5, 2019);
insert into Movies values (5, 'The Incredibles 2', 'Action', 10, 5,2019);
insert into Movies values (2, 'Breaking Bad', 'Drama', 10, 5,2017);
insert into Movies values (3, 'The Shining', 'Thriller', 7, 5, 2010);
insert into Movies values (4, 'DocumentaryUnit', 'Documentary', 2, 1, 2000);
/*		Inserting into Movies	*/
insert into Movies values (1, 'The Incredibles', 'Action', 10,5, 2019);
insert into Movies values (5, 'The Incredibles 2', 'Action', 10, 5,2019);
insert into Movies values (2, 'Breaking Bad', 'Drama', 10, 5,2017);
insert into Movies values (3, 'The Shining', 'Thriller', 7, 5, 2010);
insert into Movies values (4, 'DocumentaryUnit', 'Documentary', 2, 1, 2000);
/*		Inserting into Movies	*/
insert into Movies values (1, 'The Incredibles', 'Action', 10,5, 2019);
insert into Movies values (5, 'The Incredibles 2', 'Action', 10, 5,2019);
insert into Movies values (2, 'Breaking Bad', 'Drama', 10, 5,2017);
insert into Movies values (3, 'The Shining', 'Thriller', 7, 5, 2010);
insert into Movies values (4, 'DocumentaryUnit', 'Documentary', 2, 1, 2000);
/*		Inserting into Movies	*/
insert into Movies values (1, 'The Incredibles', 'Action', 10,5, 2019);
insert into Movies values (5, 'The Incredibles 2', 'Action', 10, 5,2019);
insert into Movies values (2, 'Breaking Bad', 'Drama', 10, 5,2017);
insert into Movies values (3, 'The Shining', 'Thriller', 7, 5, 2010);
insert into Movies values (4, 'DocumentaryUnit', 'Documentary', 2, 1, 2000);


delete  Acts_In;
delete Orders;
delete from Copies where MovieID in (select C2.MovieID from Copies as C2, Movies as M2 where C2.MovieID = M2.MovieID and M2.ReleaseYear < 2000); 
delete from Movies where ReleaseYear < 2000;
select ReleaseYear from Movies
select * from Movies where Movies.ReleaseYear = 2000;

/*		Inserting into Employees	*/
insert into Employee values (1, 'Jerome','LName','jerome@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterJerome');
insert into Employee values (2, 'Olasubomi','Badiru','badiruo@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterOlasubomi');
insert into Employee values (3, 'Brandt','LName','brandt@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterBrandt');
insert into Employee values (4, 'Marek','LName','marek@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterMarek');

select * from Employee as E where E.StartDate >= '2021-12-12';


/*		Inserting into Customers*/
insert into Customer values (1,'Mohammed','ElHajj','mohammed@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							 'Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283490, 1,
							 'BlockbusterMohammed',0);









/*		VIew Tables		*/

select * from Employee;

select * from Movies;

select * from AccType;

select * from Actors;

select * from Customer;

select * from Acts_In;

select * from Orders;

select * from Copies;




/*		drop tables		*/

USE [BLOCKBUSTER]
DELETE  Employee;
DELETE  Customer;
DELETE  Movies;
DELETE  AccType;


/*  drop tables  */

drop table Orders;
drop table Copies;
drop table Customer;
drop Table AccType;
drop table Acts_In;
drop table Movies;
drop table Actors;
drop table Employee;


/*		Testing Queries		*/

select C.Passwords from Customer as C where C.email = 'badiruo@mymacewan.ca'
Select * from Copies as C, Movies as M where C.MovieID = M.MovieID and C.OrderStatus = 1;