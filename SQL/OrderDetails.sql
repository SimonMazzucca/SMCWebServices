USE SMC;

DROP TABLE dbo.OrderDetails;
GO

CREATE TABLE dbo.OrderDetails(
	OrderDetailId		INT NOT NULL,
	OrderId			INT NOT NULL,
	ProductId		INT NOT NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[OrderDetails] VALUES (1, 1, 1009);
INSERT INTO [dbo].[OrderDetails] VALUES (2, 1, 1150);
INSERT INTO [dbo].[OrderDetails] VALUES (3, 1, 1850);
INSERT INTO [dbo].[OrderDetails] VALUES (4, 1, 1666);
