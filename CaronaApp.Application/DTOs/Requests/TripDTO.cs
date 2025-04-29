using FluentValidation;
using System.ComponentModel.DataAnnotations.Schema;

namespace CaronaApp.Application.DTOs.Requests
{
    public class TripDTO
    {
        public int Id { get; set; }
        [ForeignKey("DriverId")]
        public int DriverId { get; set; }
        public DateOnly Date { get; set; }
        public DateTime Hour { get; set; }
        public string StartAddress { get; set; } = String.Empty;
        public string EndAddress { get; set; } = String.Empty;

    }
    public class TripValidator : AbstractValidator<TripDTO>
    {
        DateOnly Date = new DateOnly();
        DateTime Time = new DateTime();
        public TripValidator()
        {
            RuleFor(x => x.DriverId).NotNull().WithMessage("O id do motorista é obrigatório");
            RuleFor(x => x.Date).NotEqual(Date).WithMessage("A data precisa ser informada");
            RuleFor(x => x.Hour).NotEqual(Time).WithMessage("A hora precisa ser informada");
            RuleFor(x => x.StartAddress).NotNull().NotEqual("").WithMessage("O endereço de início precisa ser informado");
            RuleFor(x => x.StartAddress).NotNull().NotEqual("").WithMessage("O endereço final precisa ser informado");
        }
    }

}
