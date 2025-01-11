using CaronaApp.Application.Handlers;

namespace CaronaApp.Domain.Models.RegistrationModels
{
    public class DriverRegistrationModel : RegistrationBaseModel
    {
        public string ModelCar { get; set; }
        public string NormallyRoute { get; set; }
        public decimal ValueRide { get; set; }
    }
}
