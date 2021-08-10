USE SMC;

DROP TABLE dbo.Orders;
GO

CREATE TABLE dbo.Orders(
	OrderId		INT NOT NULL,
	OrderNumber	VARCHAR(100) NOT NULL,
	OrderDate			DATE NOT NULL,
	TaxesAmount			DECIMAL(10,2),
	ShippingAmount		DECIMAL(10,2),
	TotalAmount		DECIMAL(10,2),
	ShippingMethod	VARCHAR(100) NOT NULL,
	UserId			INT NOT NULL
) ON [PRIMARY]
GO


INSERT INTO [dbo].[Orders] VALUES(1, 72356, '2021-08-03', 123.52, 30.00, 1606.72, '2-Day Rush Delivery', 1)