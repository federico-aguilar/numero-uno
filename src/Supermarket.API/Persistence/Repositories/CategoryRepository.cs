using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{

    // repository inherits the BaseRepository and implements ICategoryRepository
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            // using Categories database set to access categories table an then call extension method ToListAsync
            // ToListAsync transforms result of a query into a collection of categories bc EF Core translate method
            // call into SQL query, efficient as possible
            return await _context.Categories.ToListAsync();
        }
    }
}