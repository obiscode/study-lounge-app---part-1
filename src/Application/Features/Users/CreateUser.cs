using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace StudyLounge.Application.Features.Users;

public class CreateUserEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/api/users", async (CreateUserRequest req, IUserService userService) =>
            await userService.CreateAsync(req));
    }
}

public record CreateUserRequest(string Email, string Password);