using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Perlink.Data;

namespace Perlink.Validators
{
    //public class LoginValidator : AbstractValidator<LoginViewModel>
    public class LoginValidator
    {
        public LoginValidator()
        {
            //RuleFor(u => u.Username).NotEmpty().WithErrorCode("#000-000-000").WithMessage(DataConstants.Messages.Login.Username);
            //RuleFor(u => u.Password).NotEmpty().WithErrorCode("#000-000-000").WithMessage(DataConstants.Messages.Login.Password);
        }
    }
}
