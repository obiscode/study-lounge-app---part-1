using Carter;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudyLounge.Application.Infrastructure.Identity;
using StudyLounge.Application.Infrastructure.Persistence;

namespace StudyLounge.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddAppliccation(this IServiceCollection services)
    {
        return services
        .AddCarter();
    }
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        return services
        .AddPersistence(configuration)
        .AddIdentityDetails();
    }

    public static IEndpointRouteBuilder MapEndPoints(this IEndpointRouteBuilder builder)
    {
        builder.MapCarter();
        return builder;
    }
}