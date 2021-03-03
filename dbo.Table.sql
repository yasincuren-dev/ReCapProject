CREATE TABLE [dbo].[Car]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] INT NULL, 
    [Description] CHAR(50) NULL
)
