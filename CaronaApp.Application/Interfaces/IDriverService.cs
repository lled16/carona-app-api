using CaronaApp.Domain.Models.RegistrationModels;
using CaronaApp.Domain.Models.TripModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Application.Interfaces
{
    public interface IDriverService
    {
        Task<DriverRegistrationModel> DriverRegistration(DriverRegistrationDTO driverDTO);
        Task<List<TripModel>> GetDriverTrips(int idDriver);
    }
}
