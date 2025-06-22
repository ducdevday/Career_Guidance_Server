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
    public class SetNewPasswordValidation : AbstractValidator<SetNewPasswordRequest>
    {
        public SetNewPasswordValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("New password is required.")
                .Length(ValidationConstant.PASSWORD_MINLENGHT, ValidationConstant.PASSWORD_MAXLENGTH).WithMessage($"Password length must be between {ValidationConstant.PASSWORD_MINLENGHT} and {ValidationConstant.PASSWORD_MAXLENGTH} characters.");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("Confirm password is required.")
                .Equal(x => x.NewPassword).WithMessage("Confirm password does not match the new password.");

            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Code is required.")
                .Length(ValidationConstant.EMAIL_VERIFICATION_CODE_LENGTH).WithMessage($"Code must be {ValidationConstant.EMAIL_VERIFICATION_CODE_LENGTH} characters long.");
        }
    }
}
