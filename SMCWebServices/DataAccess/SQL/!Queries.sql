USE SMC;

--Users
SELECT * FROM [SMC].[dbo].[Users]


--Products
SELECT * FROM [SMC].[dbo].[Products] p
LEFT JOIN [SMC].[dbo].[ProductCategories] pc on p.CategoryId=pc.CategoryId


--Orders
SELECT 
	o.OrderId, o.OrderNumber, o.OrderDate, o.ShippingMethod, o.ShippingAmount, o.TaxesAmount, o.TotalAmount,
	p.Name, p.Description, p.Cost, p.Rating,
	u.FirstName + ' ' + u.LastName AS 'User'
FROM [SMC].[dbo].[Orders] o
	LEFT JOIN OrderDetails od ON o.OrderId=od.OrderId
	LEFT JOIN Users u ON o.UserId=u.UserId
	LEFT JOIN Products p ON od.ProductId=p.ProductID


Update Orders set [ExpectedDeliveryDate] = '2021-08-06'
Update Orders set [ShippingDate] = '2021-08-04'

Update OrderDetails set [Quantity] = 1