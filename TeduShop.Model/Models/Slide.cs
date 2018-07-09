using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Names { get; set; }

        [Required]
        [MaxLength(256)]
        public string Descriptions { get; set; }

        [Required]
        [MaxLength(256)]
        public string Images { get; set; }

        [Required]
        [MaxLength(256)]
        public string Urls { get; set; }

        public int? DisplayOrder { get; set; }

       
        public bool? Statuss { get; set; }
    }
}