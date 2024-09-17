using Microsoft.AspNetCore.Identity;

namespace OrderFoodOnline.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string? Name { get; set; }
    public string? Address { get; set; }
  }
}
