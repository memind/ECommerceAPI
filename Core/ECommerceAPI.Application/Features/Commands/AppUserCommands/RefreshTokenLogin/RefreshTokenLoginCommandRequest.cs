using MediatR;

namespace ECommerceAPI.Application.Features.Commands.AppUserCommands.RefreshTokenLogin
{
    public class RefreshTokenLoginCommandRequest : IRequest<RefreshTokenLoginCommandResponse>
    {
        public string RefreshToken { get; set; }
    }
}
