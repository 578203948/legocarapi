using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace legocarapi.Models
{
    public class CarState
    {
        public int Speed { get; set; } = 0;
        public Direction Direction { get; set; } = Direction.forward;
        public bool Light { get; set; } = false;
    }
}