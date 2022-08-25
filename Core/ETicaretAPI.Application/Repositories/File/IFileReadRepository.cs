using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F = ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.Application.Repositories.File
{
    public interface IFileReadRepository : IReadRepository<F.File>
    {
    }
}
