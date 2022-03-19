USE master
GO
IF DB_ID('TestDB') IS NOT NULL DROP DATABASE TestDB
GO
CREATE DATABASE TestDB
GO
USE TestDB
GO
CREATE TABLE dbo.Table1(ID INT IDENTITY, Ten VARCHAR(30) )
GO
INSERT INTO dbo.Table1(Ten)
SELECT 'Nguyen Van A' UNION ALL
SELECT 'Nguyen Van B' UNION ALL
SELECT 'Nguyen Van C'