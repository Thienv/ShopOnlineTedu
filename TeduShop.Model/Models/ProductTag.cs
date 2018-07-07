using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        private int ProductID { get; set; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        private string TagID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag tag { get; set; }

        [ForeignKey("ProductID")]
        public virtual Products product { get; set; }
    }
}