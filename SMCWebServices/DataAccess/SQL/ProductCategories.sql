USE SMC;

CREATE TABLE dbo.ProductCategories(
	CategoryId		INT NOT NULL,
	CategoryName		VARCHAR(100) NOT NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[ProductCategories] VALUES (1, 'Bass Guitars');
INSERT INTO [dbo].[ProductCategories] VALUES (2, 'Accessories');


SELECT * FROM ProductCategories
