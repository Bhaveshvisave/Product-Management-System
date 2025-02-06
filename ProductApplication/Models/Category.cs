using System.ComponentModel.DataAnnotations;

namespace ProductApplication.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100, ErrorMessage = "Category name cannot be longer than 100 characters.")]
        public required string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    }
}
