using ProductsValidation.Models;
using System.ComponentModel.DataAnnotations;
using System;
using ProductsValidation.ViewModels;

namespace ProductsValidation.Attributes
{
    public class DescriptionValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var product = (ProductViewModel)validationContext.ObjectInstance;
            string name = product.Name;
            string description = (string)value;

            if (description.Equals(name, StringComparison.OrdinalIgnoreCase) || !description.StartsWith(name, StringComparison.OrdinalIgnoreCase))
            {
                return new ValidationResult("Description should not be equal to the Name and should start with the Name of the product.");
            }

            return ValidationResult.Success;
        }
    }
}
