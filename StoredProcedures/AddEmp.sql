Alter procedure usp_AddEmployee  

(   

    @Name VARCHAR(20),    

    @ProfileImage varchar(20),
	
    @Gender VARCHAR(6) ,
	@Department varchar(6),
	@Salary int,
	@StartDate datetime,
	@Notes varchar(50)

)   

as    

Begin    

    Insert into Employee (Name,ProfileImage, Gender, Department, Salary, StartDate, Notes)    

    Values (@Name,@ProfileImage, @Gender, @Department, @Salary, @StartDate, @Notes)    
       

End