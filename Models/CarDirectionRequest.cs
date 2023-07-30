using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace legocarapi.Models
{
    public class CarDirectionRequest
    {
        [Required]
        public Direction Direction { get; set; }
    }
}