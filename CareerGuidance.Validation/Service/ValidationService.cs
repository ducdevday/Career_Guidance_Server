using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Validation.Service
{
    public class ValidationService : IValidationService
    {
        private readonly IServiceProvider _serviceProvider;

        public ValidationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<ValidationResult> ValidateAsync<T>(T instance, CancellationToken cancellationToken = default)
        {
            var validator = _serviceProvider.GetRequiredService<IValidator<T>>();
            return await validator.ValidateAsync(instance, cancellationToken);
        }
    }
}
