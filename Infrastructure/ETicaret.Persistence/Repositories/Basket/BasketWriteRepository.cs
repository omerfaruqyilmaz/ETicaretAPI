
using ETicaretAPI.Application.Repositories.Basket;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Basket
{
    public class BasketWriteRepository : WriteRepository<ETicaretAPI.Domain.Entities.Basket>, IBasketWriteRepository
    {
        public BasketWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
