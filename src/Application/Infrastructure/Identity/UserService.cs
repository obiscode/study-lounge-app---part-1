using Microsoft.AspNetCore.Identity;
using StudyLounge.Application.Features.Users;

namespace StudyLounge.Application.Infrastructure.Identity;

public class UserService(UserManager<ApplicationUser> userManager) : IUserService
{
    public async Task<string> CreateAsync(CreateUserRequest request)
    {
        var user = new ApplicationUser
        {
            Email = request.Email,
            UserName = request.Email,
            IsActive = true
        };

        var result = await userManager.CreateAsync(user, request.Password);

        if(!result.Succeeded)
        {
            //handle error
            throw new Exception(result.Errors.First().Description);
        }

        return user.Id;
    }
}