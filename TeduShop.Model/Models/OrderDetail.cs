using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Required]
        private int OrderID { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order order { get; set; }

        [Required]
        private int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Products product { get; set; }

        [Required]
        private int Quantitty { get; set; }
    }
}