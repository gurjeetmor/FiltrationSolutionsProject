using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiltrationSolutionsLtd.Models
{
    public class ProductDetails
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select image")]
        [Display(Name = "Image URL")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select the product category")]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Product name is required field")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

       
        [Display(Name = "Part Number")]
        public string PartNumber { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "EN1822")]
        public string EN1822 { get; set; }

        [Display(Name = "Dimensions WxHxD (mm)")]
        public string Dimensions { get; set; }

        [Display(Name = "Air Flow/pressure drop (m^3/hr/Pa)")]
        public string AirFlow { get; set; }

        [Display(Name = "Media area (m^2)")]
        public string MediaArea { get; set; }

        [Display(Name = "Weight (kg)")]
        public string Weight { get; set; }
    }
}