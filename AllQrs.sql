/*Edit movies*/
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
(select concat(A1.FName,' ' ,A1.LName) as ActorName, A1.ActorID
from Actors as A1) as Temp1

select M.Title 
from Movies as M, Temp1 as T and Acts_In as AI
where M.MoviesID = AI.MovieID AND T.ActorID = AI.ActorID and T.ActorName like '%key%'

