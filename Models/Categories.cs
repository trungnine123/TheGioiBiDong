using System.ComponentModel.DataAnnotations;

namespace TheGioiBiDong.Models
{
    public class Categories
    {
        [Key]
        public int? CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryDescription { get; set; }
        [Required] public int? CategoryOrder { get; set; }
        public ICollection<Products>? Products { get; set; }

    }
}
