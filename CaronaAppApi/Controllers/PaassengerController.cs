using CaronaApp.Application.Interfaces;
using CaronaApp.Domain.Models.RegistrationModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaronaAppApi.Controllers
{
    [ApiController]
    public class PaassengerController : Controller
    {

        private readonly IPassengerService _passengerService;

        public PaassengerController(IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }

        [HttpPost("create-passenger")]
        public async Task<IActionResult> Create(PassengerRegistrationDTO passenger)
        {
            var result = await _passengerService.PassengerRegistration(passenger);

            if (result.Success)
            {
                return Created();
            }

            return BadRequest(result.Message + result.Validations);
        }

    }
}
