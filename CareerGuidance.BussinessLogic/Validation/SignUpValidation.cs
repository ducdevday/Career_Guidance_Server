using CareerGuidance.Data.Enum;
using CareerGuidance.DTO.Request;
using CareerGuidance.Shared.Constant;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.BussinessLogic.Validation
{
    public class SignUpValidation : AbstractValidator<SignUpRequest>
    {
        public SignUpValidation()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required.")
                .MaximumLength(ValidationConstant.NAME_MAXLENGTH).WithMessage($"First name cannot exceed {ValidationConstant.NAME_MAXLENGTH} characters.");

            RuleFor(x => x.MiddleName)
                .MaximumLength(ValidationConstant.NAME_MAXLENGTH).WithMessage($"Middle name cannot exceed {ValidationConstant.NAME_MAXLENGTH} characters.")
                .When(x => !string.IsNullOrEmpty(x.MiddleName)); // Optional field

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required.")
                .MaximumLength(ValidationConstant.NAME_MAXLENGTH).WithMessage($"Last name cannot exceed {ValidationConstant.NAME_MAXLENGTH} characters.");

            RuleFor(x => x.Gender)
                .IsInEnum()
                .WithMessage("Invalid gender selected.");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty().WithMessage("Date of birth is required.")
                .LessThan(DateTime.Today).WithMessage("Date of birth cannot be in the future.")
                .GreaterThan(new DateTime(1900, 1, 1)).WithMessage("Date of birth is unrealistically old.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .MaximumLength(ValidationConstant.EMAIL_MAXLENGTH).WithMessage($"Email cannot exceed {ValidationConstant.EMAIL_MAXLENGTH} characters.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .MaximumLength(ValidationConstant.PHONE_MAXLENGTH).WithMessage($"Phone number cannot exceed {ValidationConstant.PHONE_MAXLENGTH} characters.")
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Invalid phone number format. It should be in E.164 format.");


            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password).WithMessage("Passwords do not match.");

        }
    }
}
