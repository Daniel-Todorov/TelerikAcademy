--Create a function that accepts as parameters – sum, 
--yearly interest rate and number of months. It should 
--calculate and return the new sum. Write a SELECT to 
--test whether the function works as expected.

USE [BankRecords]
GO

CREATE FUNCTION ufn_CalculateInterest 
	(@initialMoney money, @yearlyInterestProcentage float, @numberOfMonths int)
	RETURNS money
AS
BEGIN
DECLARE @result money
DECLARE @monthlyInterest float

SET @monthlyInterest = (@yearlyInterestProcentage / 12) / 100
SET @result = @initialMoney * (1 + (@monthlyInterest * @numberOfMonths))

RETURN @RESULT
END
GO

--Testing function
SELECT [dbo].[ufn_CalculateInterest] (100, 12, 12)
GO