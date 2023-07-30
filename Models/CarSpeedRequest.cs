using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace legocarapi.Models
{
    public class CarSpeedRequest
    {
        [Range(0, 100)]
        [Required]
        public int? Speed { get; set; }
    }
}