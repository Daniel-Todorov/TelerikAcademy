--Write SQL statements to update some of the 
--records in the Users and Groups tables. 

USE [TelerikAcademy]
GO

UPDATE [Users] 
	SET [UserName] = 'olaf' 
	WHERE [UserID] = 1
UPDATE [Groups]
	SET [GroupName] = 'Updated Group'
	WHERE [GroupID] = 2