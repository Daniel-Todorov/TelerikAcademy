--Start a database transaction, delete all employees 
--from the 'Sales' department along with all 
--dependent records from the pother tables. At the 
--end rollback the transaction. 

USE [TelerikAcademy]
GO

BEGIN TRANSACTION
	ALTER TABLE Departments
		DROP CONSTRAINT FK_Departments_Employees
	DELETE FROM Employees
		WHERE Employees.DepartmentID = (SELECT DepartmentID
											FROM Departments
                                            WHERE Departments.Name = 'Sales')                                                              
ROLLBACK TRANSACTION