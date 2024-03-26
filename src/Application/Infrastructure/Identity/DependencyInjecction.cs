using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using StudyLounge.Application.Features.Users;
using StudyLounge.Application.Infrastructure.Persistence;

namespace StudyLounge.Application.Infrastructure.Identity;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentityDetails(this IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
            options.Password.RequiredLength = 6;
            options.User.RequireUniqueEmail = true;
        }).AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();

        services.AddScoped<IUserService, UserService>();

        return services;
    }
}