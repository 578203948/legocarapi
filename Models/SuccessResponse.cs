using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace legocarapi.Models
{
    public class SuccessResponse
    {
        public Error Error { get; set; } = new Error();
        public bool Success { get; set; } = true;
        public Object Data { get; set; } = new Object();
    }
}