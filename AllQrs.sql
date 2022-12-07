/*Edit movies*/
*Edit movies*/
update Movies 
SET title = "",genre = "", fee = ""
WHERE MovieID = ID;
/*Add,Edit,Delete Employee*/
insert into Employee values ();
insert into Phone();

update Employee
SET name = "newname", email = "newemail", passwords = "newpasswords", street=,city=,zip=
WHERE Employee.ID = ID;

alter table Orders nocheck constraint all
delete from Employee
alter table Orders check constraint all

/*Get a sales report*/

/*Show all movies*/
select * from Movies


/*employee gets customer info for rent/return */
select C.CusotmerID, C.Fname , C.Email, C.ExpiryDate, A.PlanType
from Customer as C, Acctype as A
where C.PlanID = A.PlanID AND C.CustomerID = ""



/*list of movie rentals by movie name, movie type or customer name*/
select *
from Movies as M, Actors as A, Acts_IN as AI
where M.MoviesID = AI.MovieID AND A.ActorID = AI.ActorID and M.title like "%key%" or M.genre = "" or M.years = "" or A.FName like "%key%"


/*Get copies available*/
select CopyID, MovieID
from Copies 
NOT IN ( select CopyID, MovieID
			from Orders
			where DateTo < "currentDate")

/* Add new order*/
Insert Into Orders ( OrderID, CustomerID, EmployeeID, CopyID, MovieID, DateFrom, DateTo)
Values ();

/*A customer's currently held movies*/
select M.Title
from Movies as M, Orders as O 
where O.MovieID = M.MovieID AND CustomerID = "" AND DateTo>"currentdate"

/*A history of all current and past orders a customer has placed*/
select M.Title, O.DateFrom, O.DateTo 
from Movies as M, Orders as O 
where O.MovieID = M.MovieID AND CustomerID = "" 
order by O.DateFrom desc

/* Produce customer mailing lists */
select Email
from Customer 

/* Movies available with a particular keyword or set of keywords in the movie name*/
select Title
from Movies
where Title like '%keyowrd%'

/*Movies available starring a particular actor or group of actors*/
select M.Title from 
(select concat(A1.FName,' ' ,A1.LName) as ActorName, A1.ActorID
from Actors as A1) as T, Movies as M, Acts_In as AI
where M.MoviesID = AI.MovieID AND T.ActorID = AI.ActorID and T.ActorName like '%key%'

	/*Rentals for the month*/
	select * from orders where Month(DateFrom) = <month>

	/*Rentals for the year*/
	select * from orders where Year(DateFrom) = <year>

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