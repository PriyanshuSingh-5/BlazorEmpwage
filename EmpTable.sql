create database Blazor;

Create table Employee(        
    EmployeeId int IDENTITY(1,1) NOT NULL,        
    Name varchar(20) NOT NULL,        
    ProfileImage varchar(20) NOT NULL,        
   Gender varchar(20) NOT NULL,        
    Department varchar(6) NOT NULL ,
	Salary int,
	StartDate datetime,
	Notes varchar(50)
) 




select * from Employee;