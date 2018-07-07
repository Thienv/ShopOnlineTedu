using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int ID { get; set; }

        [Required]
        [MaxLength(256)]
        private string CustomerName { get; set; }

        [Required]
        [MaxLength(256)]
        private string CustomerAddres { get; set; }

        [Required]
        [MaxLength(256)]
        private string CustomerEmail { get; set; }

        [Required]
        [MaxLength(50)]
        private string CustomerMobile { get; set; }

        [Required]
        [MaxLength(256)]
        private string CustomerMessage { get; set; }

        [Required]
        [MaxLength(256)]
        private string PaymentMethod { get; set; }

        private DateTime? CreatedDate { get; set; }

        private string CreatedBy { get; set; }

        private string PaymentStatus { get; set; }

        private bool Statuss { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}