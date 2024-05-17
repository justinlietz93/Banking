BEGIN
	INSERT INTO dbo.tblCustomers (ID, SSN, FirstName, LastName, BirthDate)
	VALUES
	(1, '121-456-7890', 'John', 'Cena', '1985-07-10'),
	(2, '111-111-1111', 'Justin', 'Lietz', '1993-06-05'),
	(3, '123-555-9999', 'Mike', 'Myers', '1988-12-20')
END
GO