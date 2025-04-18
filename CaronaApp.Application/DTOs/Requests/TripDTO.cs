using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Application.DTOs.Requests
{
    public class TripDTO
    {
        public int Id { get; set; }
        [ForeignKey("DriverId")]
        public int DriverId { get; set; }
        public DateOnly Date { get; set; }
        public DateTime Start { get; set; }

    }
}
