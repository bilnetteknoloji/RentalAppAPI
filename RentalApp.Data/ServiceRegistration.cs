using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RentalApp.Data
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, string[] assemblyNames)
        {
            var availableTypes = assemblyNames.SelectMany(assemblyName => Assembly.Load(assemblyName).GetTypes()).ToList();

            var interfaceTypes = availableTypes.Where(availableType => availableType.IsInterface).ToList();
            var classTypes = availableTypes.Where(availableType => availableType.IsClass && !availableType.IsAbstract).ToList();

            interfaceTypes.ForEach(interfaceType =>
            {
                var matchingClassType = classTypes.FirstOrDefault(classType => classType.Name.Equals(interfaceType.Name.Substring(1)));

                if (matchingClassType != null)
                {
                    if (assemblyNames.Contains(matchingClassType.BaseType.FullName))
                        services.AddScoped(interfaceType, matchingClassType);
                    else
                        services.AddTransient(interfaceType, matchingClassType);
                }
            });

            return services;
        }
    }
}
