using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Application.Handlers
{
    public class BaseHandler
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = String.Empty;
        public List<ValidationFailure> Validations { get; set; } = null;
    }
}
