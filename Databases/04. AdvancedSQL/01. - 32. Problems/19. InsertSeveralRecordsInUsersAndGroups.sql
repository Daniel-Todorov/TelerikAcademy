--Write SQL statements to insert several records in 
--the Users and Groups tables.

USE [TelerikAcademy]
GO

INSERT INTO [Groups] ([GroupName]) VALUES
('First group'),
('Second group'),
('Third group')
GO

INSERT INTO [Users] ([UserName], [UserPassword], [UserFullName], [GroupID]) VALUES
('john', 'join2', 'John Black', 1),
('michael', 'gregory', 'Michael Brown', 1),
('peter', 'notepad', 'Peter Green', 3)
GO