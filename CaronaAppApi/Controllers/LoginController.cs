using CaronaApp.Application.Interfaces;
using CaronaApp.Domain.Models.RegistrationModels;
using Microsoft.AspNetCore.Mvc;

namespace CaronaAppApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IDriverService _driverService;
        private readonly IPassengerService _passengerService;

        public LoginController(IDriverService driverService, IPassengerService passengerService)
        {
            _driverService = driverService;
            _passengerService = passengerService;
        }

        [HttpPost("create-driver")]
        public async Task<IActionResult> DriverRegistration(DriverRegistrationDTO driver)
        {
            var response = await _driverService.DriverRegistration(driver);

            if (response.Success is false)
                return BadRequest(response.Message);

            return Created();
        }

        [HttpPost("create-passenger")]
        public async Task<IActionResult> PassengerRegistration(PassengerRegistrationDTO passenger)
        {
            var response = await _passengerService.PassengerRegistration(passenger);

            if (response.Success is false)
                return BadRequest(response.Message + response.Validations);

            return Created();
        }
    }
}
