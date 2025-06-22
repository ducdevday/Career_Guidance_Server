using CareerGuidance.Validation.Validation;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CareerGuidance.Validation
{
    public static class ValidationServiceRegistration
    {
        public static IServiceCollection AddApplicationValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<SignUpValidation>();
            services.AddValidatorsFromAssemblyContaining<LoginValidation>();
            services.AddValidatorsFromAssemblyContaining<VerifyEmailSignUpValidation>();
            return services;
        }
    }
}
