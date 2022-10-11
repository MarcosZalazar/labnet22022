using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP8.WebApi.Models.CategoriesDTOs
{
    public class InsertCategoryDTO
    {
        [Required]
        [Display(Name = "nombre")]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}