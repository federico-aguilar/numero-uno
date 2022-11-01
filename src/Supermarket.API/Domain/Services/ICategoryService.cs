using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

// service is class or interface that defines methods to handle some business logic (CRUD, for ex)
// using services we isolate req and res handling from real logic needed to complete tasks
// This file is NOT defining class service, just interface FOR the CategoryService.cs

// interface tells how something should work, but is NOT the actual implementation 
// using dependency injection (D.I.), can implement these interfaces and isolate them from other components

// following interface, create class that implements interface

// finally, bind references from interface to class created

namespace Supermarket.API.Domain.Services
{

    public interface ICategoryService
    {

        // Translatoin: Implementations of the ListAsync method must asynchronously 
        // return an enumeration of categories
        Task<IEnumerable<Category>> ListAsync();
    }
}