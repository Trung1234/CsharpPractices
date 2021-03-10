CREATE DATABASE [UserManagement];
USE  [UserManagement];
GO
Create Table UserProfile  
    (  
        UserId int primary key identity(1, 1),  
        UserName varchar(50),  
        Password varchar(50),  
        IsActive bit  
    )  ;
GO
Insert into UserProfile  
Select 'jaipal', 'jai1234', 1 Union All  
Select 'praveen', 'praveen1234', 1 Union All  
Select 'pruthvi', 'pruthvi1234', 1 