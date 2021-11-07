using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWepApi.Models
{
    public class TowNumber
    {
        [Required]
        public int Number1 { get; set; }

        [Required]
        public int Number2 { get; set; }
    }
}
