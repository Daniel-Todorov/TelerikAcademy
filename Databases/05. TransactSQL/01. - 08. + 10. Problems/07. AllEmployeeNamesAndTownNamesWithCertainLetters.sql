--Define a function in the database TelerikAcademy
--that returns all Employee's names (first or middle or 
--last name) and all town's names that are comprised 
--of given set of letters. Example 'oistmiahf' will 
--return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

USE [TelerikAcademy]
GO

CREATE FUNCTION IsComprisedOfLetters 
	(@word nvarchar(50), @letters nvarchar(20))
	RETURNS BIT
AS
BEGIN

DECLARE @numberOfLetters int
DECLARE @matches int
DECLARE @currentLetter nvarchar(1)

SET @numberOfLetters = LEN(@letters)
SET @matches = 0

WHILE(@numberOfLetters > 0)
BEGIN
	SET @currentLetter = SUBSTRING(@letters, @numberOfLetters, 1)
	IF(CHARINDEX(@currentLetter, @word, 0) > 0)
		BEGIN
			SET @matches += 1
			SET @numberOfLetters -= 1
		END
	ELSE
		SET @numberOfLetters -= 1
END

IF(@matches >= LEN(@word))
	BEGIN
		RETURN 1
	END
RETURN 0
END

GO

CREATE FUNCTION GetPersonNamesAndTownsWithCertainLetters
	(@letters nvarchar(50))
	RETURNS @result TABLE ([Name of person or town] varchar(50) NOT NULL)
AS
BEGIN

INSERT INTO @result
	SELECT [FirstName] FROM [Employees]

--INSERT INTO @result
--	SELECT [MiddleName]  FROM [Employees]

INSERT INTO @result
	SELECT [LastName] FROM [Employees]

INSERT INTO @result
	SELECT [Name] FROM [Towns]

DELETE FROM @result
	WHERE [dbo].[IsComprisedOfLetters] ([Name of person or town], @letters) = 0

RETURN
END

GO

SELECT * 
FROM [dbo].[GetPersonNamesAndTownsWithCertainLetters]('aifosrob')