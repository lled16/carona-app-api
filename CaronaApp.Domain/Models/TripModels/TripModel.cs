using CaronaApp.Domain.Models.PassengerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
