using CareerGuidance.DTO.Request;
using CareerGuidance.Shared.Constant;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Validation.Validation
{
    public class ForgotPasswordValidation : AbstractValidator<ForgotPasswordRequest>
    {
        public ForgotPasswordValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format."); 
        }
    }
}
