using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SMCWebServices.DataAccess.Domain
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
