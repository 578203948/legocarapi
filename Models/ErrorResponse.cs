using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace legocarapi.Models
{
    public class ErrorResponse
    {
        public Error Error { get; set; } = new Error();
        public ErrorResponse(Error error)
        {
            Error = error;
        }
    }
}