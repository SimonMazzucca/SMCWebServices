using System;
using System.Collections.Generic;

namespace SMCWebServices.Domain
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
    }
}
