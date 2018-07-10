using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Names { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Images { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descriptions { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategorie PostCategory { set; get; }

        public bool Status { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}