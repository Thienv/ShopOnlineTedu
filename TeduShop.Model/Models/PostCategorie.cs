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
        private int ID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        private string Alias { get; set; }

        [MaxLength(500)]
        private string Descriptions { get; set; }

        
        private int? ParentID { get; set; }

        
        private int? DisplayOrder { get; set; }

        [MaxLength(256)]
        private string Images { get; set; }

        
        private bool? HomeFlag { get; set; }
        public virtual IEnumerable<Post> post { get; set; }
    }
}