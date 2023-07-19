

using Microsoft.AspNetCore.Identity;

namespace ECommerceAPI.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public string NameSurname { get; set; }
    }
}
