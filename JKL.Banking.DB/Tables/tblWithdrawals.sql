CREATE TABLE [dbo].[tblWithdrawals]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Amount] FLOAT NOT NULL, 
    [Date] DATE NOT NULL, 
    [CustID] INT NOT NULL
)
