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
    public class UpdateUserValidation : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserValidation()
        {
            RuleFor(x => x.UserId)
           .NotEmpty().WithMessage("UserId is required.");

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(ValidationConstant.NAME_MAXLENGTH).WithMessage($"First name cannot exceed {ValidationConstant.NAME_MAXLENGTH} characters.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(ValidationConstant.NAME_MAXLENGTH).WithMessage($"Last name cannot exceed {ValidationConstant.NAME_MAXLENGTH} characters.");

            RuleFor(x => x.MiddleName)
                .MaximumLength(ValidationConstant.NAME_MAXLENGTH).WithMessage($"Middle name cannot exceed {ValidationConstant.NAME_MAXLENGTH} characters.")
                .When(x => !string.IsNullOrWhiteSpace(x.MiddleName));

            RuleFor(x => x.Gender)
                .IsInEnum().WithMessage("Gender is invalid.");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required.")
                .LessThan(DateTime.Now).WithMessage("Date of birth must be in the past.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email is not valid.")
                .MaximumLength(ValidationConstant.EMAIL_MAXLENGTH).WithMessage($"Email cannot exceed {ValidationConstant.EMAIL_MAXLENGTH} characters.");
        }
    }
}
