CREATE DATABASE testDB;
GO
USE [TestDB]  
GO  
/****** Object: Table [dbo].[Employees] Script Date: 5/28/2021 7:42:51 PM ******/  
SET ANSI_NULLS ON  
GO  
SET QUOTED_IDENTIFIER ON  
GO  
CREATE TABLE [dbo].[Employees](  
[Id] [int] IDENTITY(1,1) NOT NULL,  
[Name] [nvarchar](max) NOT NULL,  
[Salary] [int] NOT NULL,  
[ManagerId] [int] NOT NULL,  
CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED  
(  
   [Id] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]  
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]  
GO  

insert dbo.Employees  
Values ('Greg', 100000, 1),  
       ('George', 150000, 1),  
       ('Helen', 130000, 1),  
       ('Tom', 120000, 2),  
       ('Kevin', 110000, 2),  
       ('David', 120000, 3),  
       ('Geek', 110000,3),  
       ('Tesla', 120000,3)  