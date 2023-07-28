using MediatR;

namespace ECommerceAPI.Application.Features.Queries.AppUserQueries.GetAllUsers
{
    public class GetAllUsersQueryRequest : IRequest<GetAllUsersQueryResponse>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
