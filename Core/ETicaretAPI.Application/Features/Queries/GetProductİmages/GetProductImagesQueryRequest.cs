using MediatR;

namespace ETicaretAPI.Application.Features.Queries.GetProductİmages
{
    public class GetProductImagesQueryRequest : IRequest<List<GetProductImagesQueryResponse>>
    {
        public string Id { get; set; }
    }
}
