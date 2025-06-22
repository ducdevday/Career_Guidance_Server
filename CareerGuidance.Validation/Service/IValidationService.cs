using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Validation.Service
{
    public interface IValidationService
    {
        Task<ValidationResult> ValidateAsync<T>(T instance, CancellationToken cancellationToken = default);
    }

}
