# BlazorEmployeeCrud set up for sql setup 

create Database BzrEmployeeDB,

use BzrEmployeeDB,

Create table Employee(        
    EmployeeId int IDENTITY(1,1) NOT NULL,        
    Name varchar(20) NOT NULL,        
    City varchar(20) NOT NULL,        
    Department varchar(20) NOT NULL,        
    Gender varchar(6) NOT NULL
	        
) 


