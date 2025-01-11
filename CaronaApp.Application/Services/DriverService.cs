using AutoMapper;
using CaronaApp.Application.Interfaces;
using CaronaApp.Domain.Models.RegistrationModels;
using CaronaApp.Domain.Models.TripModels;

namespace CaronaApp.Application.Services
{
    public class DriverService : IDriverService
    {
        private readonly IMapper _mapper;

        public DriverService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<List<TripModel>> GetDriverTrips(int idDriver)
        {
            return new List<TripModel>();
        }

        public async Task<DriverRegistrationModel> DriverRegistration(DriverRegistrationDTO driverDTO)
        {
            try
            {
                var driver = _mapper.Map<DriverRegistrationModel>(driverDTO);

                driver.Success = true;

                return driver;
            }
            catch (Exception ex)
            {
                return new DriverRegistrationModel()
                {
                    Success = false,
                    Message = " Erro ao cadastrar usuário "
                };
            }
        }
    }
}
