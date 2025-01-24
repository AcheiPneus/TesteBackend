using System.Diagnostics;
using TesteBackend.Models;

namespace TesteBackend.Services;

public class ProductService(TestDbContext context)
{
    public IEnumerable<Product> GetAll()
    {
        return context.Products.ToList().OrderBy(p => p.DateCreated);
    }

    public Product? GetById(int id)
    {
        return context.Products.Find(id);
    }
}