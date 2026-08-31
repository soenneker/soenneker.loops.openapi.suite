using Microsoft.Extensions.DependencyInjection;
using Soenneker.Loops.Contacts.Registrars;

namespace Soenneker.Loops.OpenApi.Suite.Registrars;

/// <summary>
/// Registers the Loops contact operation package through a single suite entry point.
/// </summary>
public static class LoopsOpenApiSuiteRegistrar
{
    /// <summary>
    /// Adds loops open api suite as singleton.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddLoopsOpenApiSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddLoopsContactsUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds loops open api suite as scoped.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddLoopsOpenApiSuiteAsScoped(this IServiceCollection services)
    {
        services.AddLoopsContactsUtilAsScoped();

        return services;
    }
}
