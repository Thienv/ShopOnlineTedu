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
        private int ID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Names { get; set; }

        [Required]
        [MaxLength(256)]
        private string Alias { get; set; }

        [Required]
        private int CategoryID { get; set; }

        [Required]
        [MaxLength(256)]
        private string Images { get; set; }

        [Required]
        private XElement MoreImages { get; set; }

        [Required]
        private decimal Price { get; set; }

        private decimal? PromotionPrice { get; set; }

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