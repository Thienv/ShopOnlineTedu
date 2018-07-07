using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int ID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Names { get; set; }

        [Required]
        [MaxLength(256)]
        private string Descriptions { get; set; }

        [Required]
        [MaxLength(256)]
        private string Images { get; set; }

        [Required]
        [MaxLength(256)]
        private string Urls { get; set; }

        private int? DisplayOrder { get; set; }

       
        private bool? Statuss { get; set; }
    }
}