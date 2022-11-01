using System.Colections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;

namespace Supermaket.API.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> ListAsync()
        {
            
        }
    }
}