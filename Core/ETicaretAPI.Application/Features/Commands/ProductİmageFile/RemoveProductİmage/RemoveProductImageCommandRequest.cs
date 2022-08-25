using MediatR;

namespace ETicaretAPI.Application.Features.Commands.ProductİmageFile.RemoveProductİmage
{
    public class RemoveProductImageCommandRequest : IRequest<RemoveProductImageCommandResponse>
    {
        public string Id { get; set; }
        public string? ImageId { get; set; }
    }
}
