USE [master]
GO

/****** Object:  Database [PerformanceTesting]    Script Date: 2.9.2014 г. 12:48:05 ч. ******/
CREATE DATABASE [PerformanceTesting]
 CONTAINMENT = NONE
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PerformanceTesting].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

CREATE TABLE Logs(
  LogDate datetime NOT NULL,
  MsgText nvarchar(300) NOT NULL,
)
GO