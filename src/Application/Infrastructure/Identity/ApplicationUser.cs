using Microsoft.AspNetCore.Identity;

namespace StudyLounge.Application.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string? DisplayName { get; set; }
    public int? Age { get; set; }
    public Gender? Gender { get; set; }
    public string? Location { get; set; }

    public string? AvartarUrl { get; set; }
    public string? ProfileBannerUrl { get; set; }
    public string? AboutMe { get; set; }

    public bool IsActive { get; set; }
}

public enum Gender
{
    Male = 0,
    Female = 1
}