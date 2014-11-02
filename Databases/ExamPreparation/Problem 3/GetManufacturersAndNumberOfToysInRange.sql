--2.	Get all manufacturers’ name and how many toys they have in the age range of 5 to 10 years, inclusive

USE [ToyStore]
GO

SELECT m.[Name],
COUNT(*) AS [Toys in age range of 5 to 10 years inclusive]
FROM [Toys] t
	INNER JOIN [Manufacturers] m
		ON t.[Manufacturer] = m.[Id]
	INNER JOIN [AgeRanges] ar
		ON ar.[Id] = t.[AgeRange]
WHERE ar.[MinAge] >= 5 AND ar.[MaxAge] <= 10
GROUP BY m.[Name]
