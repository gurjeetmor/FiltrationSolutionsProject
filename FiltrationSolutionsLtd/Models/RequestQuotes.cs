using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiltrationSolutionsLtd.Models
{
    public class RequestQuotes
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This is a required field")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This is a required field")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This is a required field")]
        [Display(Name = "Phone")]
        public int Phone { get; set; }

        [Display(Name = "Email-Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your Email-Id")]
        //[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter Valid Email ID")]
        [EmailAddress(ErrorMessage = "Please enter valid Email address")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This is a required field")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Optional Message")]
        public string Message { get; set; }
    }
}