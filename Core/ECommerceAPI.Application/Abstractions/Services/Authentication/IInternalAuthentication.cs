using d = ECommerceAPI.Application.DTOs;

namespace ECommerceAPI.Application.Abstractions.Services.Authentication
{
    public interface IInternalAuthentication
    {
        Task<d.Token> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
    }
}
