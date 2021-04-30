SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TRUNGNT
-- Create date: 2-4-2021
-- Description:	Register User
-- =============================================
CREATE OR ALTER PROCEDURE spRegisterUser 
( 
    @FirstName VARCHAR(20), 
    @LastName VARCHAR(20) , 
    @UserID VARCHAR(20) , 
    @UserPassword VARCHAR(20)  
) 
AS 
BEGIN 
   
    DECLARE @result VARCHAR(10) ='Failed'
   
    IF NOT EXISTS(SELECT 1 FROM sysUser where UserID=@UserID) 
    BEGIN    
        INSERT INTO sysUser 
        VALUES  
        (  
            @FirstName,@LastName,@UserID,@UserPassword 
        ) 
           
        SET @result= 'Success' 
    END  
   
        SELECT @result AS Result 
END
GO
