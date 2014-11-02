--Create another table – Logs(LogID, AccountID, 
--OldSum, NewSum). Add a trigger to the Accounts
--table that enters a new entry into the Logs table 
--every time the sum on an account changes.

USE [BankRecords]
GO

CREATE TRIGGER [tr_BalanceUpdate] ON [Accounts] FOR UPDATE
AS
	DECLARE @accountID int
	DECLARE @oldSum money
	DECLARE @newSum money

	SET @accountID = (SELECT [AccountID] FROM deleted)
	SET @oldSum = (SELECT [Balance] FROM deleted)
	SET @newSum = (SELECT [Balance] FROM inserted)

	INSERT INTO [Logs] ([AccountID], [OldSum], [NewSum]) VALUES (@accountID, @oldSum, @newSum)
GO

--Test
UPDATE [Accounts] 
	SET [Balance] = 9999 
	WHERE [AccountID] = 1

SELECT *
	FROM [Logs]