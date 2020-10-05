using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Lab_2.Models.Computer;

namespace Lab_2.Models
{
    public class AddViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Invalid Length")]
        public string Name { get; set; }

        [Required]
        public ComputerType Type { get; set; }

        [Required]
        [Range(1, 20)]
        public int Count { get; set; }

        [Required]
        [Range(10, 150000)]
        public decimal Value { get; set; }

        public string Description { get; set; }
    }
}
