using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMCWebServices.DataAccess.Domain
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }

        public List<OrderDetail> Orders { get; set; }
    }
}
