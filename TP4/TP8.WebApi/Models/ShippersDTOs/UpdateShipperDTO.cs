using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP8.WebApi.Models.ShippersDTOs
{
    public class UpdateShipperDTO
    {
        [Required]
        [Display(Name = "nombre de la compañia")]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }
    }
}