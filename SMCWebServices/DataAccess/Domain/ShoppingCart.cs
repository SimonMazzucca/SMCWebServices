using System;
using System.Collections.Generic;
using System.Linq;

namespace SMCWebServices.DataAccess.Domain
{
    public class ShoppingCart
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string OrderStatus { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public IList<Product> Products { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ShippingAndHandling { get; set; }
        public decimal Taxes { get; set; }
        public decimal Total { get; set; }

        public ShoppingCart(Order order)
        {
            // Main
            OrderId = order.OrderId;
            CustomerId = order.UserID;
            OrderStatus = order.Status;
            TrackingNumber = order.TrackingNumber;
            
            // Dates
            OrderDate = order.OrderDate;
            ShippingDate = order.ShippingDate;

            // Products
            Products = GetAsProducts(order.OrderDetails);

            // Total
            Subtotal = order.OrderDetails.Sum(od => od.Product.Cost);
            ShippingAndHandling = order.ShippingAmount;
            Taxes = order.TaxesAmount;
            Total = Subtotal + ShippingAndHandling + Taxes;
        }

        private IList<Product> GetAsProducts(List<OrderDetail> orderDetails)
        {
            IList<Product> products = new List<Product>();

            foreach (var od in orderDetails)
            {
                Product p = new Product();
                p.Cost = od.Product.Cost;
                p.Description = od.Product.Description;
                p.ProductId = od.Product.ProductId;
                p.Name = od.Product.Name;
                products.Add(p);
            }

            return products;
        }
    }
}
