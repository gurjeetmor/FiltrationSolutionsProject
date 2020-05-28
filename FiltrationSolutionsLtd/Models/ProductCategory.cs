using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiltrationSolutionsLtd.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter product category name")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select image")]
        [Display(Name = "Image URL")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Category Description is required field")]
        [Display(Name = "Category Description")]
        public string CategoryDescription { get; set; }

        List<Product> Products { get; set; }
    }
}