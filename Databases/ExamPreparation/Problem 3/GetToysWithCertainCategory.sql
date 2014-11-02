--3.	Get all toys’ name, price and color from category “boys” 

USE [ToyStore]
GO

SELECT t.[Id], t.[Name], t.[Price], t.[Color]
FROM [Toys] t
	INNER JOIN [ToysCategories] tc
		ON t.[Id] = tc.[ToyId]
	INNER JOIN [Categories] c
		ON c.[Id] = tc.[CategoryId]
WHERE c.[Name] = 'boys'