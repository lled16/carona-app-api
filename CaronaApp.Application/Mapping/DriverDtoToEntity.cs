using AutoMapper;
using CaronaApp.Domain.Models.RegistrationModels;

namespace CaronaApp.Application.Mapping
{
    public class DriverDtoToEntity : Profile
    {
        public DriverDtoToEntity()
        {
            CreateMap<DriverRegistrationDTO, DriverRegistrationModel>()
                .ForMember(x => x.FirstName, y => y.MapFrom(x => x.FirstName))
                .ForMember(x => x.LastName, y => y.MapFrom(x => x.LastName))
                .ForMember(x => x.Email, y => y.MapFrom(x => x.Email))
                .ForMember(x => x.Password, y => y.MapFrom(x => x.Password))
                .ForMember(x => x.Phone, y => y.MapFrom(x => x.Phone))
                .ForMember(x => x.HomeCity, y => y.MapFrom(x => x.HomeCity))
                .ForMember(x => x.FullAddress, y => y.MapFrom(x => x.FullAddress))
                .ForMember(x => x.PostalCode, y => y.MapFrom(x => x.PostalCode))
                .ForMember(x => x.FinalAddress, y => y.MapFrom(x => x.FinalAddress))
                .ForMember(x => x.ProfilePhoto, y => y.MapFrom(x => x.ProfilePhoto))
                .ForMember(x => x.ModelCar, y => y.MapFrom(x => x.ModelCar))
                .ForMember(x => x.NormallyRoute, y => y.MapFrom(x => x.NormallyRoute))
                .ForMember(x => x.ValueRide, y => y.MapFrom(x => x.ValueRide));
        }
    }
}
