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
        private int ID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Names { get; set; }

        [Required]
        [MaxLength(256)]
        private string Alias { get; set; }

        [Required]
        [MaxLength(256)]
        private string Descriptions { get; set; }

      
        private int? ParentID { get; set; }

       
        private int? DisplayOrder { get; set; }

        [Required]
        [MaxLength(256)]
        private string Images { get; set; }

      
        private bool? HomeFlag { get; set; }
        public virtual IEnumerable<Products> product { get; set; }
    }
}