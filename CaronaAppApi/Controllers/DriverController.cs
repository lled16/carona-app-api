using CaronaApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CaronaAppApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        [HttpGet("get-trips-by-driver/{id}")]
        public async Task<IActionResult> GetTripsByDriver(int id)
        {
            var trips = await _driverService.GetDriverTrips(id);

            if (trips is null)
                return NoContent();

            return Ok(trips);
        }
    }
}
