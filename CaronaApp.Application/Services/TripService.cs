using AutoMapper;
using CaronaApp.Application.DTOs.Requests;
using CaronaApp.Application.Interfaces;
using CaronaApp.Domain.Models.TripModels;
using FluentValidation.Results;

namespace CaronaApp.Application.Services
{
    public class TripService : ITripService
    {
        private readonly IMapper _mapper;

        public TripService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<TripModel> CreateTrip(TripDTO tripDTO)
        {
            try
            {
                TripValidator validator = new TripValidator();

                ValidationResult result = validator.Validate(tripDTO);

                if (result.IsValid)
                {
                    return new TripModel();
                }

                return new TripModel() { Success = false, Message = "Erro ao cadastrar viagem", Validations = result.Errors.ToList() };

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
