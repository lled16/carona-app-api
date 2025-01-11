using AutoMapper;
using CaronaApp.Application.Interfaces;
using CaronaApp.Domain.Models.RegistrationModels;
using FluentValidation.Results;

namespace CaronaApp.Application.Services
{
    public class PassengerService : IPassengerService
    {
        private readonly IMapper _mapper;

        public PassengerService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<PassengerRegistrationModel> PassengerRegistration(PassengerRegistrationDTO passengerDTO)
        {
            try
            {
                RegistrationValidator validator = new RegistrationValidator();

                ValidationResult result = validator.Validate(passengerDTO);

                if (result.IsValid is false)
                    return new PassengerRegistrationModel()
                    {
                        Success = false,
                        Message = "Erro ao cadastrar usuário",
                        Validations = result.Errors.ToList()
                    };

                var passenger = _mapper.Map<PassengerRegistrationModel>(passengerDTO);

                passenger.Success = true;

                return passenger;
            }
            catch (Exception ex)
            {
                return new PassengerRegistrationModel()
                {
                    Success = false,
                    Message = " Erro ao cadastrar usuário " + ex.Message
                };
            }
        }
    }
}
