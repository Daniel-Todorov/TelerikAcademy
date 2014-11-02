--Create a stored procedure that uses the function 
--from the previous example to give an interest to a 
--person's account for one month. It should take the 
--AccountId and the interest rate as parameters.

USE [BankRecords]
GO

CREATE PROCEDURE [usp_GiveInterestForOneMonth]
	(@accountID int, @interestRate float)
AS
DECLARE @currentMoneyInAccount money
DECLARE @newMoneyInAccount money

SET @currentMoneyInAccount = (SELECT [Balance] FROM [Accounts] WHERE [AccountID] = @accountID)
SET @newMoneyInAccount = (SELECT [dbo].[ufn_CalculateInterest] (@currentMoneyInAccount, @interestRate, 1))-- (SELECT [ufn_CalculateInterest] (@currentMoneyInAccount, @interestRate, 1))

UPDATE [Accounts]
	SET [Balance] = @newMoneyInAccount
	WHERE [AccountID] = @accountID
GO

DECLARE	@return_value int

EXEC @return_value = [dbo].[usp_GiveInterestForOneMonth]
		@accountID = 1,
		@interestRate = 12

SELECT 'Return Value' = @return_value

GO
