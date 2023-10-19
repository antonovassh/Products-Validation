using Microsoft.AspNetCore.Mvc.Rendering;
using ProductsValidation.Attributes;
using ProductsValidation.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProductsValidation.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Description length should be between 3 and 100 characters.")]
        [DescriptionValidation]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0, 100000, ErrorMessage = "Price should be between 0 and 100,000.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public Product.Category Type { get; set; }

        public SelectList CategoryList { get; set; } 
    }
}
