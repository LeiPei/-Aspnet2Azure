using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Medhat1124.Models.NorthWind  // change namespace to be the same as the class model
{
    [MetadataType(typeof(CategoryMetaData))] // get definition of the type class
    public partial class Category { }


    public class CategoryMetaData
    {
        [Required]
        [Display(Name = "Category Name")]
        public object CategoryName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        public object Description { get; set; }
    }


}