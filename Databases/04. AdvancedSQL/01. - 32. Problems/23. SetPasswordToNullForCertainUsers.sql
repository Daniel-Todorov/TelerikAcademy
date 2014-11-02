--Write a SQL statement that changes the password 
--to NULL for all users that have not been in the 
--system since 10.03.2010. 

USE [TelerikAcademy]
GO

UPDATE [Users]
	SET [UserPassword] = NULL
	WHERE [LastLoginTime] < CONVERT(datetime, '2010-03-10')

--NOTE!!! Make sure you've changed some of the login times to point a date before 10.03.2010