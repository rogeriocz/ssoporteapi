using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using pmx.ssoporte.Application.Interfaces.FharmacyMedication;
using pmx.ssoporte.Infrastructure.Persistence.Context;
using pmx.ssoporte.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmx.ssoporte.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            // Registro del PharmacyDbContext
            services.AddSingleton<PharmacyDbContext>();
            // Registro del MedicationRepository
            services.AddScoped<IMedicationRepository, MedicationRepository>();

            return services;
        }
    }
}
