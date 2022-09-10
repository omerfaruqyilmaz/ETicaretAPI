using MediatR;

namespace ETicaretAPI.Application.Features.Commands.Basket.RemoveBasketItem
{
    public partial class RemoveBasketItemCommandHandler
    {
        public class RemoveBasketItemCommandRequest : IRequest<RemoveBasketItemCommandResponse>
        {
            public string BasketItemId { get; set; }
        }
    }
}
