using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int ID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Names { get; set; }

        [Required]
        [MaxLength(256)]
        private string Alias { get; set; }

        private string Content { get; set; }
    }
}