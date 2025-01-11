using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Domain.Models.RegistrationModels
{
    public class DriverRegistrationDTO : RegistrationBaseDTO
    {
        public string ModelCar { get; set; }
        public string NormallyRoute { get; set; }
        public decimal ValueRide { get; set; }
    }
}
