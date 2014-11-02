--Write a SQL statement to add a column GroupID to 
--the table Users. Fill some data in this new column 
--and as well in the Groups table. Write a SQL 
--statement to add a foreign key constraint between 
--tables Users and Groups tables. USE [TelerikAcademy]IF EXISTS (SELECT * FROM sys.columns 
        WHERE [name] = N'GroupID' AND [object_id] = OBJECT_ID(N'Users'))
BEGIN
	ALTER TABLE [Users]
		DROP CONSTRAINT [FK_Users_Groups]
	ALTER TABLE [Users] 
		DROP COLUMN [GroupID]
ENDELSEBEGIN	ALTER TABLE [Users] 		ADD [GroupID] int	ALTER TABLE [Users] ADD CONSTRAINT [FK_Users_Groups]		FOREIGN KEY ([GroupID])		REFERENCES [Groups]([GroupID])END--NOTE!!! Please, make sure the Users table is cleared of all records--before executing this query.