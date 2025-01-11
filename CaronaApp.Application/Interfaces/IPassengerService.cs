using CaronaApp.Domain.Models.RegistrationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Application.Interfaces
{
    public interface IPassengerService
    {
        Task<PassengerRegistrationModel> PassengerRegistration(PassengerRegistrationDTO passengerDTO);
    }
}
