--Create a stored procedure that accepts a number as 
--a parameter and returns all persons who have more 
--money in their accounts than the supplied number.

USE [BankRecords]
GO

CREATE PROC [ups_SelectPersonsWithCertainAmountOfMoney]
	(@lowerAmountOfMoney money = 0)
AS 
	SELECT p.FirstName + ' ' + p.[LastName] AS [Selected Persons]
	FROM [Persons] p
	INNER JOIN [Accounts] a
		ON p.[PersonID] = a.[PersonID]
	GROUP BY p.[PersonID], p.FirstName + ' ' + p.[LastName]
		HAVING SUM(a.[Balance]) > @lowerAmountOfMoney
GO

DECLARE	@return_value int
EXEC @return_value = [dbo].[ups_SelectPersonsWithCertainAmountOfMoney]
		@lowerAmountOfMoney = 1300
SELECT 'Return Value' = @return_value
GO