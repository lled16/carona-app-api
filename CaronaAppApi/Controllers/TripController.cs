using Microsoft.AspNetCore.Mvc;

namespace CaronaAppApi.Controllers
{
    [ApiController]
    public class TripController : Controller
    {
        [HttpGet("get-all-trips")]
        public async Task<IActionResult> GetAllTrips()
        {
            return View();
        }

        [HttpGet("get-all-trips")]
        public async Task<IActionResult> GetTripsFilter()
        {
            return View();
        }

        [HttpPost("create-trip")]
        public async Task<IActionResult> CreateTrip()
        {
            return View();
        }
    }
}
