using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Application.DTOs.Responses
{
    public class ResponseBase
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
