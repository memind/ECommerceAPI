using MediatR;
using Microsoft.AspNetCore.Http;

namespace ECommerceAPI.Application.Features.Commands.ProductImageFileCommands.UploadProductImage
{
    public class UploadProductImageCommandRequest : IRequest<UploadProductImageCommandResponse>
    {
        public string Id { get; set; }
        public IFormFileCollection? Files { get; set; }
    }
}
