CREATE TABLE [dbo].[tblDeposits]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Amount] FLOAT NOT NULL, 
    [Date] DATE NOT NULL, 
    [CustID] INT NOT NULL
)
