CREATE TABLE [dbo].[tblCustomers]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [SSN] VARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL
)
