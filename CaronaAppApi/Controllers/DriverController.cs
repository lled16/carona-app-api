using CaronaApp.Application.Interfaces;
using CaronaApp.Domain.Models.RegistrationModels;
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

        [HttpPost("create-driver")]
        public async Task<IActionResult> Create(DriverRegistrationDTO driver)
        {
            var result = await _driverService.DriverRegistration(driver);
            
            if (result.Success)
            {
                return Created();
            }

            return BadRequest(result.Message + result.Validations);
        }
    }
}
