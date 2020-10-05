using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_2.Models
{
    public class Computer
    {
        public enum ComputerType 
        {
            [Display(Name = "Phone")]
            Phone,
            [Display(Name = "Laptop")]
            Laptop,
            [Display(Name = "Mouse")]
            Mouse,
            [Display(Name = "Keyboard")]
            Keyboard
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ComputerType Type { get; set; }

        public int Count { get; set; }

        public decimal Value { get; set; }

        public string Description { get; set; }
    }
}
