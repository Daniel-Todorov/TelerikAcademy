--Create a database with two tables: 
--Persons(Id(PK), FirstName, LastName, SSN) and 
--Accounts(Id(PK), PersonId(FK), Balance). 
--Insert few records for testing. Write a stored 
--procedure that selects the full names of all persons.

--NOTE!!! Please, attached the database that you'll find in the hoemwork folder before runnign the queries.

USE [BankRecords]
GO

CREATE PROC [ups_SelectPersonsFullName]
AS
	SELECT [FirstName] + ' ' + [LastName] AS [Full Name]
	FROM [Persons]
GO

DECLARE	@return_value int
EXEC @return_value = [dbo].[ups_SelectPersonsFullName]
SELECT 'Return Value' = @return_value
GO