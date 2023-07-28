using MediatR;

namespace ECommerceAPI.Application.Features.Queries.AppUserQueries.GetRolesToUser
{
    public class GetRolesToUserQueryRequest : IRequest<GetRolesToUserQueryResponse>
    {
        public string UserId { get; set; }
    }
}
