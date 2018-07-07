using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int ID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Names { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        private string Alias { get; set; }

        [Required]
        private int CategoryID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Images { get; set; }

        [Required]
        [MaxLength(500)]
        private string Descriptions { get; set; }

        private string Content { get; set; }

        private bool? HomeFlag { get; set; }

        private bool? HotFlag { get; set; }

        private int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategorie PostCategory { set; get; }
    }
}