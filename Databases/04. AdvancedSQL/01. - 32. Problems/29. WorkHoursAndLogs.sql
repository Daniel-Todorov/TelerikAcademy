--Write a SQL to create table WorkHours to store 
--work reports for each employee (employee id, date, 
--task, hours, comments). Don't forget to define 
--identity, primary key and appropriate foreign key. 
-- Issue few SQL statements to insert, update and 
--delete of some data in the table. 
-- Define a table WorkHoursLogs to track all changes 
--in the WorkHours table with triggers. For each 
--change keep the old record data, the new record 
--data and the command (insert / update / delete). 

USE [TelerikAcademy]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkHours]') AND type in (N'U'))
	DROP TABLE [dbo].[WorkHours]
GO

CREATE TABLE [WorkHours](
	[WorkHoursID] int IDENTITY PRIMARY KEY,
	[EmployeeID] int NOT NULL,	[Date] datetime NOT NULL,	[Tasks] nvarchar(250),	[Hours] decimal(5,2),	[Comments] nvarchar(250)	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY (EmployeeID) 
		REFERENCES [Employees] (EmployeeID),
)
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WorkHoursLogs]') AND type in (N'U'))
	DROP TABLE [dbo].[WorkHoursLogs]
GO

CREATE TABLE [WorkHoursLogs](
	[WorkHoursLogID] int IDENTITY PRIMARY KEY,
	[ActionType] nvarchar(10) NOT NULL,
	[WorkHoursID] int, --No need to make tis foreign key because in that case we won't be able to delete the record and test the triggers
	[EmployeeID] int NOT NULL,	[DateOld] datetime NOT NULL,	[DateNew] datetime NOT NULL,	[Tasks] nvarchar(250),	[Hours] decimal(5,2),	[Comments] nvarchar(250)
)
GO

CREATE TRIGGER tr_WorkHoursInsert ON WorkHours FOR INSERT
AS
DECLARE @WorkHoursID int, @EmployeeID int, @DateOld datetime, @Tasks nvarchar(250), @Hours decimal(5,2), @Comments nvarchar(250)

SET @WorkHoursID = (SELECT WorkHoursID FROM inserted)
SET @EmployeeID = (SELECT EmployeeID FROM inserted)
SET @DateOld = (SELECT Date FROM inserted)
SET @Tasks= (SELECT Tasks FROM inserted)
SET @Hours = (SELECT Hours FROM inserted)
SET @Comments = (SELECT Comments FROM inserted)

INSERT INTO [WorkHoursLogs] ([ActionType], [WorkHoursID], [EmployeeID], [DateOld], [DateNew], [Tasks], [Hours], [Comments]) 
	VALUES ('insert', @WorkHoursID, @EmployeeID, @DateOld, GETDATE(), @Tasks, @Hours, @Comments)
GO

CREATE TRIGGER tr_WorkHoursDelete ON WorkHours FOR DELETE
AS
DECLARE @WorkHoursID int, @EmployeeID int, @DateOld datetime, @Tasks nvarchar(250), @Hours decimal(5,2), @Comments nvarchar(250)

SET @WorkHoursID = (SELECT WorkHoursID FROM deleted)
SET @EmployeeID = (SELECT EmployeeID FROM deleted)
SET @DateOld = (SELECT Date FROM deleted)
SET @Tasks= (SELECT Tasks FROM deleted)
SET @Hours = (SELECT Hours FROM deleted)
SET @Comments = (SELECT Comments FROM deleted)

INSERT INTO [WorkHoursLogs] ([ActionType], [WorkHoursID], [EmployeeID], [DateOld], [DateNew], [Tasks], [Hours], [Comments]) 
	VALUES ('delete', @WorkHoursID, @EmployeeID, @DateOld, GETDATE(), @Tasks, @Hours, @Comments)
GO

CREATE TRIGGER tr_WorkHoursUpdate ON WorkHours FOR UPDATE
AS
DECLARE @WorkHoursID int, @EmployeeID int, @DateOld datetime, @Tasks nvarchar(250), @Hours decimal(5,2), @Comments nvarchar(250)

SET @WorkHoursID = (SELECT WorkHoursID FROM deleted)
SET @EmployeeID = (SELECT EmployeeID FROM deleted)
SET @DateOld = (SELECT Date FROM deleted)
SET @Tasks= (SELECT Tasks FROM deleted)
SET @Hours = (SELECT Hours FROM deleted)
SET @Comments = (SELECT Comments FROM deleted)

INSERT INTO [WorkHoursLogs] ([ActionType], [WorkHoursID], [EmployeeID], [DateOld], [DateNew], [Tasks], [Hours], [Comments]) 
	VALUES ('updated old', @WorkHoursID, @EmployeeID, @DateOld, GETDATE(), @Tasks, @Hours, @Comments)

SET @WorkHoursID = (SELECT WorkHoursID FROM inserted)
SET @EmployeeID = (SELECT EmployeeID FROM inserted)
SET @DateOld = (SELECT Date FROM inserted)
SET @Tasks= (SELECT Tasks FROM inserted)
SET @Hours = (SELECT Hours FROM inserted)
SET @Comments = (SELECT Comments FROM inserted)

INSERT INTO [WorkHoursLogs] ([ActionType], [WorkHoursID], [EmployeeID], [DateOld], [DateNew], [Tasks], [Hours], [Comments]) 
	VALUES ('updated new', @WorkHoursID, @EmployeeID, @DateOld, GETDATE(), @Tasks, @Hours, @Comments)
GO

INSERT INTO [WorkHours]([EmployeeID], [Date], [Tasks], [Hours], [Comments])
VALUES (1, GETDATE(), 'Develop app', 8, 'It will be hard!');

INSERT INTO [WorkHours]([EmployeeID], [Date], [Tasks], [Hours], [Comments])
VALUES (5, GETDATE(), 'Develop headache', 1, 'Easy stuff. Just write few queries!');

DELETE FROM WorkHours
WHERE EmployeeID = 5;

UPDATE WorkHours
SET [Comments] = 'HAD TO BE DONE LAST WEEK!'
WHERE [WorkHoursID] = 1
GO

--Something is wrong withthe update trigger, no idea what...