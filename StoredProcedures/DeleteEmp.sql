Create procedure usp_DeleteEmp    

(     

   @EmployeeId int     

)     

as      

begin     

   Delete from Employee where EmployeeId=@EmployeeId     

End