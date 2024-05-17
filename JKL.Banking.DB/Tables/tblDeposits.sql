CREATE TABLE dbo.tblDeposits (
    ID int PRIMARY KEY,
    Amount float NOT NULL,
    Date datetime NOT NULL, 
    [CustID] INT NOT NULL
);
