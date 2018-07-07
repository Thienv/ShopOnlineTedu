using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        private string ID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Content { get; set; }
    }
}