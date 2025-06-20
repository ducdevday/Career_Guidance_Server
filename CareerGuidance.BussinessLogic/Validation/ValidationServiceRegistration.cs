using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.BussinessLogic.Validation
{
    public static class ValidationServiceRegistration
    {
        public static IServiceCollection AddApplicationValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<SignUpValidation>();
            return services;
        }
    }
}
