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
        public DateTime OrderDate { get; set; }
        public decimal TaxesAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal TotalAmount { get; set; }

        public List<OrderDetail> Orders { get; set; }

    }

}