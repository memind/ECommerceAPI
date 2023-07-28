using ECommerceAPI.Application.Abstractions.Services;
using MediatR;

namespace ECommerceAPI.Application.Features.Commands.AppUserCommands.AssignRoleToUser
{
    public class AssignRoleToUserCommandHandler : IRequestHandler<AssignRoleToUserCommandRequest, AssignRoleToUserCommandResponse>
    {
        readonly IUserService _userService;
        public AssignRoleToUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<AssignRoleToUserCommandResponse> Handle(AssignRoleToUserCommandRequest request, CancellationToken cancellationToken)
        {
            await _userService.AssignRoleToUserAsnyc(request.UserId, request.Roles);
            return new();
        }
    }
}
