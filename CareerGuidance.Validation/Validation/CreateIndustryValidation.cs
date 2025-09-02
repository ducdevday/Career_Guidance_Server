using CareerGuidance.DTO.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Validation.Validation
{
    public class CreateIndustryValidation : AbstractValidator<CreateIndustryRequest>
    {
        public CreateIndustryValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.Icon)
                .NotEmpty().WithMessage("Icon is required.");
        }
    }
}
