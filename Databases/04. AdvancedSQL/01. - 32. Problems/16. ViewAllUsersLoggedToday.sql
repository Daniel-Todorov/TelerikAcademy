--Write a SQL statement to create a view that displays 
--the users from the Users table that have been in the 
--system today. Test if the view works correctly. 

USE [TelerikAcademy]
GO

CREATE VIEW [All users logged today] AS
SELECT *
FROM [Users]
WHERE CONVERT(VARCHAR, [LastLoginTime], 112) = CONVERT(VARCHAR, GETDATE(), 112);

--NOTE!!! SSMS displays [Users] and [LastLoginTime] with red underlining.
--Don't worry, the code still executes flawlessly.
--NOTE!!! You can test the view by making few new records in the Users table in TelerikAcademy DB.
--Go to the folder Views, right click on the newly created view and you'll see the result of it.
--Make sure you change the date of at least one of the users so that you can check the difference.