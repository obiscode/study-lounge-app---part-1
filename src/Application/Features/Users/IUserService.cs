namespace StudyLounge.Application.Features.Users;

public interface IUserService
{
    Task<string> CreateAsync(CreateUserRequest request);
}