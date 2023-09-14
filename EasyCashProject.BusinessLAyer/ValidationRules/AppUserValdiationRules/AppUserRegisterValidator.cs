using EasyCashProject.DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashProject.BusinessLAyer.ValidationRules.AppUserValdiationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("This field cannot be left blank.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("This field cannot be left blank.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("This field cannot be left blank.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("This field cannot be left blank.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("This field cannot be left blank.");

            RuleFor(x => x.ConfirmPassword).Equal(Y=>Y.Password).WithMessage("Your passwords are different from each other.");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Please, enter a valid e-mail address.");

        }
    }
}
