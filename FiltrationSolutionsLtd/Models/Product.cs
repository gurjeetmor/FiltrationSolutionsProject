using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiltrationSolutionsLtd.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Product name is required field")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select image")]
        [Display(Name = "Image URL")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        public string AltText { get; set; }

        [DataType(DataType.Html)]
        public string Caption { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Product Description is required field")]
        [Display(Name = "Product Description")]       
        public string ProductDescription { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please select the product category")]
        public int CategoryId { get; set; }

        List<ProductDetails> ProductDetails { get; set; }

        //List<ProductDescriptionModel> ProductsDescriptionModel { get; set; }
    }
}