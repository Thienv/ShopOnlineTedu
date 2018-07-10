using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategorie : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Descriptions { get; set; }

        
        public int? ParentID { get; set; }

        
        public int? DisplayOrder { get; set; }

        [MaxLength(256)]
        public string Images { get; set; }

        
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Post> post { get; set; }
        public bool Status { get; set; }
    }
}