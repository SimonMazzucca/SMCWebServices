USE SMC;

--Users
SELECT * FROM SMC.dbo.Users


--Products
SELECT * FROM SMC.dbo.Products p
LEFT JOIN SMC.dbo.ProductCategories pc on p.CategoryId=pc.CategoryId


--Orders
SELECT 
	o.OrderId, o.OrderNumber, o.ShippingMethod, o.Status,
	o.OrderDate, o.ShippingDate, o.ExpectedDeliveryDate, o.DeliveryDate,
	o.ShippingAmount, o.TaxesAmount, o.TotalAmount,
	p.Name, p.Description, p.Cost, p.Rating,
	u.FirstName + ' ' + u.LastName AS 'User'
FROM SMC.dbo.Orders o
	LEFT JOIN OrderDetails od ON o.OrderId=od.OrderId
	LEFT JOIN Users u ON o.UserId=u.UserId
	LEFT JOIN Products p ON od.ProductId=p.ProductID



SELECT 
	o.OrderNumber, o.ShippingMethod, o.Status,
	o.OrderDate, o.ShippingDate, o.ExpectedDeliveryDate,
	o.ShippingAmount, o.TaxesAmount, o.TotalAmount,
	u.FirstName + ' ' + u.LastName AS 'User'
FROM SMC.dbo.Orders o
	LEFT JOIN Users u ON o.UserId=u.UserId


