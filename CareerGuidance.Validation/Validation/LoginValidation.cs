using CareerGuidance.DTO.Request;
using FluentValidation;

namespace CareerGuidance.Validation.Validation
{
    public class LoginValidation : AbstractValidator<LoginRequest>
    {
        public LoginValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");
        }
    }
}
