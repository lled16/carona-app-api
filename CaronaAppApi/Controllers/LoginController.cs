using CaronaApp.Application.Interfaces;
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


    }
}
