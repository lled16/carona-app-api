using FluentValidation;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaronaApp.Domain.Models.RegistrationModels
{
    public class RegistrationBaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string HomeCity { get; set; }
        public string FullAddress { get; set; }
        public string PostalCode { get; set; }
        public string? FinalAddress { get; set; }
        public string? ProfilePhoto { get; set; }
    }

    public class RegistrationValidator : AbstractValidator<RegistrationBaseDTO>
    {
        public RegistrationValidator()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("O nome é obrigatório");
            RuleFor(x => x.LastName).NotNull().WithMessage("O nome é obrigatório");
            RuleFor(x => x.Email).NotNull().WithMessage("O email é obrigatório");
            RuleFor(x => x.Password).Length(6, 15).WithMessage("O campo senha é obrigatório e a senha deve conter de 6 a 15 caracteres");
            RuleFor(x => x.Phone).NotNull().WithMessage("O telefone é obrigatório");
            RuleFor(x => x.HomeCity).NotNull().WithMessage("A cidade em que reside é obrigatória");
            RuleFor(x => x.FullAddress).NotNull().WithMessage("O endereço é obrigatório");
            RuleFor(x => x.PostalCode).NotNull().WithMessage("O CEP é obrigatório");
        }
    }
}


