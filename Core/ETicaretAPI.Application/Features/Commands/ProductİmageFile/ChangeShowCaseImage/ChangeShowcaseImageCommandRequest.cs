using MediatR;

namespace ETicaretAPI.Application.Features.Commands.ProductİmageFile.ChangeShowCaseImage
{
    public class ChangeShowcaseImageCommandRequest : IRequest<ChangeShowcaseImageCommandResponse>
    {
        public string ImageId { get; set; }
        public string ProductId { get; set; }
    }
}
