using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategorie : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Names { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        [Required]
        [MaxLength(256)]
        public string Descriptions { get; set; }

      
        public int? ParentID { get; set; }

       
        public int? DisplayOrder { get; set; }

        [Required]
        [MaxLength(256)]
        public string Images { get; set; }

      
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Products> product { get; set; }
    }
}