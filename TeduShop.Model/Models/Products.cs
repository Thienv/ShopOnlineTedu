using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Products
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
        public int CategoryID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Images { get; set; }

     
        [Column(TypeName ="xml")]
        public string MoreImages { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategorie ProdutCategory { set; get; }
    }
}