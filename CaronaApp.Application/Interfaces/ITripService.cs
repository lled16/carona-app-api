using CaronaApp.Application.DTOs.Requests;
using CaronaApp.Domain.Models.TripModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Application.Interfaces
{
    public interface ITripService
    {
        Task<TripModel> CreateTrip(TripDTO tripDTO);
    }
}
