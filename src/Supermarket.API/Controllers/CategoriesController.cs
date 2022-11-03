// Handling requests and responses 

// allows us access to Controller class and <IEnumerable>
using System.Collections.Generic;
// allows Task
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;

// Namespace constists of related classes, interfaces, enums, and structs
// similar to modules of JS
namespace Supermaket.API.Controllers
{
    // Controller will respond at /api/categories due to Route attribute
    // we specifiy a placeholder to indicate that route should use class name, Category, WITHOUT controller suffix
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // HttpGet attribute tells ASP.NET Core pipeline to use this method to handle GET; optional, improves readability
        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}