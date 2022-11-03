using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{

    // An abstract class that all our repositories will inherit
    // abstract class is one that doesn't have direct instances
    // HAVE to CREATE direct classes to create the isntances
    public abstract class BaseRepository 
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}