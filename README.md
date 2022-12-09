# CMPT 291 GROUP PROJECT
Group Members:

Olasubomi Badiru
Brandt Sanche 
Jerome verghese
Marek Maisonneuve

# Connection String
The ***connection string*** variable is located in ***SQL_Conn.cs***. Modifying this connection string will allow the program to work with any database. Change this to whatever the SQL setup is.

# Approach Taken: BLOCKBUSTER Recreation
### Entity-Relationship Model and Tables
Tables were created for Movies, Copies, Orders, Customers, Employees.
Personal information is stored about all the customers and employees in the database, and the user of the application is able to add new customers and employees within certain interfaces of the application.
The user of the application is able to create new orders, new movies in the database, view amounts of copies available and view sales reports of employees. The user is also allowed to view information specific to each user, employee and movies.

### Referential Integrity
The tables created for our application reference eachother, and the foreign keys are clearly labled in the tables. In the customers table, a foreign key is referenced in PlanID, which specifies which account type the user has. In the Copies table, a foreign key references MovieID. The copies can only exist if the movie does, so if the movie is deleted the deletion query cascades and removes the entry in the Copies table. The Acts_In table references ActorID as a foreign key reference, and if actors are removed the update is cascaded and is removed from the Acts_IN table.

The Orders table has multiple foreign key references, and includes CopyID, MovieID, CustomerID and EmployeeID. The table stores this information so it can display to the user comprehensive information about an order. If any of the information is removed, the updates cascade and properly remove entries from the other tables.



### Login Screen
The user is presented with a login screen, and prompted to enter a username and password. The user can then specify if the user is a customer or an employee. The username and password are checked against either the ***Customer or Employee*** tables in our database. If the username and password match an entry in the table, the user is presented with the next screen.

# Customer Home Page
The customer is presented with options to view their profile, which shows them all the info on their profile such as name, age, gender, address, account info.

### Categories
The user is shown a table showing all the possible movie categories. Clicking on the respective tab will show all movies in the catalog that are under that category.

# Employee Home Page
If the user logs in as an employee, the user is presented with options to edit users, edit movies, rent movies out to users, process returns and view sales reports.

### Edit movies
The user is able to add movies to the database with all its respective fields, such as title, genre, year released and fee for renting. The user is also able to remove movies from the database entirely by specifying either a title or a movie ID

### Users Page
The user is presented with multiple tabs with different functionality. Users are able to add new employees or customer accounts and view info about accounts. Each of these different sets of features are shown on different tabs. Each user specified has specific info that is displayed to the user.

### Rentals
Entering a CustomerID will present all info to the user. After the user enters the customer to rent movies to, the user is presented with search information to select which movie will be rented to the user. The user is able to select movies based on title, genre, actor or year released. The user then enters what days to rent the movie from and until. The user will then be asked to confirm the order.

### Returns
The returns page presents a table to the user and prompts to enter either a customer ID or a movie ID. Entering either of these will show all the orders with the respective ID in it. The user is then able to select the ID to mark it as returned. This will also update it in the database and make it available to all other users/

### Reports Page
The user is prompted with the options to view sales reports for customers, employees, movies and overall sales report. The customer page shows how many movies are signed out per user. The users can be sorted in order by address, amount of movies possessed, gender, email, start date and return date.
The employee section of the reports page shows information about all employees, and can be sorted by address, salary, gender, email and starting date.
The overall sales reports section allows the user to view the amount of each specific movie that were rented out in any given month and year.
The second tab on the page allows the user to view employee or customer sales for any given month and year. The user is also able to view overdue rentals that have not been returned yet.
