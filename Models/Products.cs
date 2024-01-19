using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace TheGioiBiDong.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string? ProductName { get; set; }
        [StringLength(500)]
        public string? ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
        [Required]
        public int ? ProductQuantity { get; set; }
        [StringLength(50)]
        public string? ProductImage { get; set; }

        [ForeignKey("CategoriesId")]
        public int? CategoryId { get; set; }

        public Categories? Categories { get; set; }
        [ForeignKey("BrandId")]
        public int BrandId { get; set; }

        public Brand? Brand { get; set; }

    }
}
