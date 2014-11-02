--1.	Get all toys’s name and price having type of “puzzle” and price above $10.00 ordering them by price

USE [ToyStore]
GO

SELECT [Name], [Price]
FROM [Toys]
WHERE [Type] = 'puzzle' AND [Price] > 10
ORDER BY [Price]