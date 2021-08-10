using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMCWebServices.DataAccess.Domain
{

    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }

}
