USE SMC;

DROP TABLE dbo.Orders;
GO

CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL,
	[OrderNumber] [varchar](100) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[TaxesAmount] [decimal](10, 2) NULL,
	[ShippingAmount] [decimal](10, 2) NULL,
	[TotalAmount] [decimal](10, 2) NULL,
	[ShippingMethod] [varchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
	[Status] [varchar](100) NULL,
	[TrackingNumber] [varchar](100) NULL,
	[ShippingDate] [date] NULL,
	[ExpectedDeliveryDate] [date] NULL,
	[DeliveryDate] [date] NULL
)


INSERT INTO [dbo].[Orders]
    ([OrderId]
    ,[OrderNumber]
    ,[OrderDate]
    ,[TaxesAmount]
    ,[ShippingAmount]
    ,[TotalAmount]
    ,[ShippingMethod]
    ,[UserId]
    ,[Status]
    ,[TrackingNumber]
    ,[ShippingDate]
    ,[ExpectedDeliveryDate]
    ,[DeliveryDate]
)
VALUES
    (1
    ,72356
    ,'2021-08-03'
    ,123.52
    ,30.00
    ,1606.72
    ,'2-Day Rush Delivery'
    ,1
    ,'Processing'
    ,NULL
    ,NULL
    ,'2021-08-03'
    ,'2021-08-05'
)

update [Orders] set Status = 'Processing' where OrderId=1
update [Orders] set Status = 'Shipped' where OrderId=1