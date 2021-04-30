SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TRUNGNT
-- Create date: 2-4-2021
-- Description:	Register User
-- ============================================= 
CREATE OR ALTER PROCEDURE spValidateUserLogin 
( 
    @LoginID VARCHAR(20) , 
    @LoginPassword VARCHAR(20) 
) 
AS 
BEGIN 
   
    DECLARE @authentication VARCHAR(10)='Failed' 
   
    IF EXISTS(SELECT 1 FROM sysUser WHERE UserID=@LoginID AND Password = @LoginPassword) 
    BEGIN 
        SET @authentication='Success' 
    END 
       
    SELECT @authentication AS isAuthenticated 
   
END
GO
