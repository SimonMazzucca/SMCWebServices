USE SMC;

DROP TABLE dbo.Products;
GO

CREATE TABLE dbo.Products(
	ProductID		INT NOT NULL,
	Name	VARCHAR(100) NOT NULL,
	Description		VARCHAR(100) NOT NULL,
	Rating	DECIMAL(2,1),
	CategoryId			INT NOT NULL,
	Cost				MONEY NOT NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[Products] VALUES (1009, 'Fender Precision Bass', 'Fender Deluxe Precision Bass White Pearl', 4.5, 1, 1299.99);
INSERT INTO [dbo].[Products] VALUES (1150, 'Fender Bass Bag', 'Fender FB620 Electric Bass Gig Bag', 4.0, 2, 59.99);
INSERT INTO [dbo].[Products] VALUES (1850, 'D''Addario Bass String Set', 'D''Addario EXL170BT Electric Bass String Set', 4.2, 2, 36.63);
INSERT INTO [dbo].[Products] VALUES (1666, 'Guitar Picks', 'Bass Guitar Pick (Variety Pack)', 4.7, 2, 4.99);
