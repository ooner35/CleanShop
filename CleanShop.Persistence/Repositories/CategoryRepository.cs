using CleanShop.Application.Services.Repositories;
using CleanShop.Domain.Entities;
using CleanShop.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanShop.Persistence.Repositories
{
    public class CategoryRepository : EfRepositoryBase<Category, BaseDbContext>, ICategoryRepository
    {
        public CategoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
