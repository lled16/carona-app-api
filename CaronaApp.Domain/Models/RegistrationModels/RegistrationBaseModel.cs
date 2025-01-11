using CaronaApp.Application.Handlers;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Domain.Models.RegistrationModels
{
    public class RegistrationBaseModel : BaseHandler
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string HomeCity { get; set; }
        public string FullAddress { get; set; }
        public string PostalCode { get; set; }
        public string? FinalAddress { get; set; }
        public string? ProfilePhoto { get; set; }
    }
}
