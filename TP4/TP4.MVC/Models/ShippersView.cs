using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP4.MVC.Models
{
    public class ShippersView
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "nombre de la compañia")]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }
    }
}