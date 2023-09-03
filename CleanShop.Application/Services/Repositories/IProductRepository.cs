using CleanShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanShop.Application.Services.Repositories
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
    }
}
