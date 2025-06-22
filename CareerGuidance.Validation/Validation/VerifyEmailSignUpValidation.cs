using CareerGuidance.DTO.Request;
using CareerGuidance.DTO.Response;
using CareerGuidance.Shared.Constant;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Validation.Validation
{
    public class VerifyEmailSignUpValidation : AbstractValidator<VerifyEmailSignUpRequest>
    {
        public VerifyEmailSignUpValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Verification code is required.")
                .Length(ValidationConstant.EMAIL_VERIFICATION_CODE_LENGTH).WithMessage($"Verification code must be exactly {ValidationConstant.EMAIL_VERIFICATION_CODE_LENGTH} characters long.");
        }
    }
}
