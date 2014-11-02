--Add two more stored procedures WithdrawMoney( 
--AccountId, money) and DepositMoney 
--(AccountId, money) that operate in transactions.

USE [BankRecords]
GO

CREATE PROCEDURE [ups_WithdrawMoney]
	(@accountID int, @amountOfMoneyToWithdraw money)
AS

IF (NOT EXISTS(SELECT * FROM [Accounts] WHERE [AccountID] = @accountID))
BEGIN
RAISERROR ('Withdraw account does not exists.', 16, 1)
RETURN
END

	DECLARE @initialMoney money
	DECLARE @moneyAfterWithdrawal money

	SET @initialMoney = (SELECT [Balance] FROM [Accounts] WHERE [AccountID] = @accountID)
	SET @moneyAfterWithdrawal = @initialMoney - @amountOfMoneyToWithdraw

	UPDATE [Accounts]
		SET [Balance] = @moneyAfterWithdrawal
		WHERE [AccountID] = @accountID
GO

CREATE PROCEDURE [ups_DepositMoney]
	(@accountID int, @amountOfMoneyToDeposit money)
AS

IF (NOT EXISTS(SELECT * FROM [Accounts] WHERE [AccountID] = @accountID))
BEGIN
RAISERROR ('Deposit account does not exists.', 16, 1)
RETURN
END

	DECLARE @initialMoney money
	DECLARE @moneyAfterDeposit money

	SET @initialMoney = (SELECT [Balance] FROM [Accounts] WHERE [AccountID] = @accountID)
	SET @moneyAfterDeposit = @initialMoney + @amountOfMoneyToDeposit

	UPDATE [Accounts]
		SET [Balance] = @moneyAfterDeposit
		WHERE [AccountID] = @accountID
GO

CREATE PROCEDURE [ups_TransferMoney]
	(@fromAccount int, @toAccount int, @amountOfMoney money)
AS
BEGIN TRANSACTION
	EXEC [dbo].[ups_WithdrawMoney]
		@accountID = @fromAccount,
		@amountOfMoneyToWithdraw = @amountOfMoney
	EXEC [dbo].[ups_DepositMoney]
		@accountID = @toAccount,
		@amountOfMoneyToDeposit = @amountOfMoney

IF @@ERROR <> 0
BEGIN
	ROLLBACK
	RETURN
END
ELSE
BEGIN
COMMIT
END
GO

--Test
EXEC [dbo].[ups_TransferMoney]
	@fromAccount = 1,
	@toAccount = 4,
	@amountOfMoney = 50