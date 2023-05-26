using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net_Oponeo.Models
{
    public class Rim
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Material { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Manufacturer { get; set; }
    }
}
