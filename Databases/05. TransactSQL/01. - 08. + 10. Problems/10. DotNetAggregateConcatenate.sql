--Define a .NET aggregate function StrConcat that 
--takes as input a sequence of strings and return a 
--single string that consists of the input strings 
--separated by ','.

--NOTE!!! Take in mind we should use a .dll file.
--I've placed it in the homework folder - StringUtils.dll
--A little bit lower you'll see a comment to change the file path to that .dll file according to your file structure.

sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO

USE TelerikAcademy
GO

IF OBJECT_ID(N'Concatenate', N'AF') is not null
DROP Aggregate Concatenate;
GO

IF EXISTS (SELECT * FROM sys.assemblies WHERE [name] = 'StringUtils')
DROP ASSEMBLY StringUtils;
GO

DECLARE @SamplePath nvarchar(1024)
--Set @SamplePath = the path in your computer to the .dll file
Set @SamplePath = 'C:\Users\Annonymous\Desktop\Telerik Academy\Databases\05. TransactSQL\'
CREATE ASSEMBLY [StringUtils] 
FROM @SamplePath + 'StringUtils.dll'
WITH permission_set = Safe;
GO

CREATE AGGREGATE [dbo].[Concatenate](@input nvarchar(4000))
RETURNS nvarchar(4000)
EXTERNAL NAME [StringUtils].[Concatenate];
GO

SELECT [dbo].[Concatenate](FirstName + ' ' + LastName)
FROM Employees
WHERE EmployeeID < 10