
/*		DATE format: YYYY-MM-DD		*/

USE [BLOCKBUSTER]

/*		Inserting into Movies	*/
insert into Movies values (1, 'The Incredibles', 'Action', 10,2019, 5);
insert into Movies values (5, 'The Incredibles 2', 'Action', 10, 2019, 5);
insert into Movies values (2, 'Breaking Bad', 'Drama', 10, 2017,5);
insert into Movies values (3, 'The Shining', 'Thriller', 7, 2010, 5);
insert into Movies values (4, 'DocumentaryUnit', 'Documentary', 2, 2000, 1);



/*		Inserting into Employees	*/
insert into Employee values (1, 'Jerome','LName','jerome@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterJerome');
insert into Employee values (2, 'Olasubomi','Badiru','badiruo@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterOlasubomi');
insert into Employee values (3, 'Brandt','LName','brandt@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterBrandt');
insert into Employee values (4, 'Marek','LName','marek@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', 10000, 'BlockbusterMarek');



/*		Inserting into Customers*/
insert into Customer values (1,'Mohammed','ElHajj','mohammed@mymacewan.ca','M','MacEwan Residence', 'Edmonton',
							'Alberta', 'T6V0L5', '2022-01-01', '2023-01-01',30283490, 1,
							'BlockbusterMohammed');




/*		Inserting into Account Type(PlanID, PlanName, PlanCost, PlanLimit)	*/
insert into  AccType values (1, 'Basic', 10, 2);
insert into  AccType values (2, 'Essential', 15, 5);
insert into  AccType values (3, 'Premium', 20,10);




/*		VIew Tables		*/

select * from Employee;


select * from Movies;

select * from AccType;

select * from Customer;



/*		drop tables		*/

USE [BLOCKBUSTER]
DELETE  Employee;
DELETE  Customer;
DELETE  Movies
DELETE  AccType;


/*		Testing Queries		*/

select C.Passwords from Customer as C where C.email = 'badiruo@mymacewan.ca'