using CaronaApp.Application.DTOs.Requests;
using CaronaApp.Application.Interfaces;
using CaronaApp.Domain.Models.TripModels;
using Microsoft.AspNetCore.Mvc;

namespace CaronaAppApi.Controllers
{
    [ApiController]
    public class TripController : Controller
    {
        private readonly ITripService _tripService;

        public TripController(ITripService tripService)
        {
            _tripService = tripService;
        }

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
        public async Task<IActionResult> CreateTrip(TripDTO tripDTO)
        {
            var result = await _tripService.CreateTrip(tripDTO);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message + result.Validations);
        }
    }
}
