using CareerGuidance.DTO.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Validation.Validation
{
    public class RegisterMentorValidation : AbstractValidator<RegisterMentorRequest>
    {

        public RegisterMentorValidation()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.YOE).GreaterThanOrEqualTo(0).WithMessage("Experience must be a non-negative number");
            RuleFor(x => x.Position).NotEmpty().WithMessage("Position is required");
            RuleFor(x => x.IndustryId).NotEmpty().WithMessage("Industry is required");
        }
    }
}
