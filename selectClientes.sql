USE [Taller]
IF OBJECT_ID ('selectCombos','P') IS NOT NULL 
DROP PROCEDURE selectCombos;
GO
CREATE PROCEDURE selectCombos
AS
BEGIN
	SELECT * FROM dbo.combos
	ORDER BY IdCliente DESC
END




