CREATE TABLE tblWithdrawals (
    ID int PRIMARY KEY,
    CustID int FOREIGN KEY REFERENCES tblCustomers(ID) NOT NULL,
    Amount float NOT NULL,
    Date datetime NOT NULL
);