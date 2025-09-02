using CareerGuidance.DTO.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Validation.Validation
{
    public class UpdateIndustryValidation : AbstractValidator<UpdateIndustryRequest>
    {
        public UpdateIndustryValidation()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id is required.")
                .GreaterThan(0).WithMessage("Id must be greater than 0.");
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.Icon)
                .NotEmpty().WithMessage("Icon is required.");
        }
    }
}
