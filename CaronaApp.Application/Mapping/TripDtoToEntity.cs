using AutoMapper;
using CaronaApp.Application.DTOs.Requests;
using CaronaApp.Domain.Models.RegistrationModels;
using CaronaApp.Domain.Models.TripModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Application.Mapping
{
    public class TripDtoToEntity : Profile
    {
        public TripDtoToEntity()
        {
            CreateMap<TripDTO, TripModel>()
                .ForMember(x => x.Id, y => y.MapFrom(x => x.Id))
                .ForMember(x => x.DriverId, y => y.MapFrom(x => x.DriverId))
                .ForMember(x => x.Date, y => y.MapFrom(x => x.Date))
                .ForMember(x => x.Hour, y => y.MapFrom(x => x.Hour))
                .ForMember(x => x.StartAddress, y => y.MapFrom(x => x.StartAddress))
                .ForMember(x => x.EndAddress, y => y.MapFrom(x => x.EndAddress));

        }
    }
}
