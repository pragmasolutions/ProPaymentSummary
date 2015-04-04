﻿CREATE TABLE [dbo].[Patient]
(
	[PatientId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(250) NOT NULL, 
    [DNI] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(250) NULL, 
    [Phone] VARCHAR(50) NULL, 
    [Email] VARCHAR(250) NULL
)
