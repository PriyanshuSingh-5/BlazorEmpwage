Create procedure usp_UpdateCustomer     

(     

   @EmployeeId int,   

   @Name VARCHAR(20),    

    @ProfileImage varchar(20),
	
    @Gender VARCHAR(6) ,
	@Department varchar(6),
	@Salary int,
	@StartDate datetime,
	@Notes varchar(50) 

)     

as     

begin     

   Update Employee 

   set Name=@Name,     
   Department=@Department,
   Salary=@Salary,
   Notes=@Notes,
     

   Gender=@Gender     

   where EmployeeId =@EmployeeId  

End