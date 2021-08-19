using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMCWebServices.DataAccess.Domain
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int UserID { get; set; }
        public string OrderNumber { get; set; }
        public string ShippingMethod { get; set; }
        public string Status { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public decimal TaxesAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal TotalAmount { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }

}