using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP8.WebApi.Models
{
    public class SimpsonsEpisodesView
    {
        public int Season { get; set; }
        public int Episode { get; set; }
        public string Name { get; set; }
    }
}