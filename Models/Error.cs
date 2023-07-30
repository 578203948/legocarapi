using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace legocarapi.Models
{
    public class Error
    {
        public string Message { get; set; } = "";
        public int Code { get; set; } = 0;
    }
}