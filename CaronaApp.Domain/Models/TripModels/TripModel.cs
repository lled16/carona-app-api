using CaronaApp.Application.Handlers;
using CaronaApp.Domain.Models.PassengerModels;

namespace CaronaApp.Domain.Models.TripModels
{
    public class TripModel : BaseHandler
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Hour { get; set; }
        public string StartAddress { get; set; } = String.Empty;
        public string EndAddress { get; set; } = String.Empty;
        public List<PassengerModel> Passengers { get; set; }
    }
}
