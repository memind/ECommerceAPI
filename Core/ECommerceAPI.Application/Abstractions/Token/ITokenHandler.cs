using Dto = ECommerceAPI.Application.DTOs;

namespace ECommerceAPI.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        Dto.Token CreateAccessToken(int minute);
    }
}
