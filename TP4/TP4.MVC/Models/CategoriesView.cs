using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP4.MVC.Models
{
    public class CategoriesView
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="nombre")]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}