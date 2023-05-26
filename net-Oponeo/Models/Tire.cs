using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_Oponeo.Models
{
    public class Tire
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Season { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Manufacturer { get; set; }
    }
}
