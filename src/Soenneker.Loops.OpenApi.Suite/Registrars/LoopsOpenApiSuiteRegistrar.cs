using Microsoft.Extensions.DependencyInjection;
using Soenneker.Loops.Contacts.Registrars;

namespace Soenneker.Loops.OpenApi.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for Loop.so's OpenApi operations
/// </summary>
public static class LoopsOpenApiSuiteRegistrar
{
    public static IServiceCollection AddLoopsOpenApiSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddLoopsContactsUtilAsSingleton();

        return services;
    }

    public static IServiceCollection AddLoopsOpenApiSuiteAsScoped(this IServiceCollection services)
    {
        services.AddLoopsContactsUtilAsScoped();

        return services;
    }
}