USE SMC;

CREATE TABLE dbo.ProductCategories(
	CategoryId		INT NOT NULL,
	CategoryName		VARCHAR(100) NOT NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[ProductCategories] VALUES (1, 'Bass Huitars');
INSERT INTO [dbo].[ProductCategories] VALUES (2, 'Accessories');
