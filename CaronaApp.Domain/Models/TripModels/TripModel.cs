using CaronaApp.Domain.Models.PassengerModels;

namespace CaronaApp.Domain.Models.TripModels
{
    public class TripModel
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Hour { get; set; }
        public string DestinyAddress { get; set; }
        public List<PassengerModel> Passengers { get; set; }
    }
}
