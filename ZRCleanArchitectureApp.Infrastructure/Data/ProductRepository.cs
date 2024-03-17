using Microsoft.EntityFrameworkCore;
using ZRCleanArchitectureApp.Domain.Entities;
using ZRCleanArchitectureApp.Domain.Interfaces;
using ZRCleanArchitectureApp.Infrastructure.Persistence;

namespace ZRCleanArchitectureApp.Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            // Use Entity Framework Core to query the products
            // and return them as a list asynchronously.
            return await _context.Products.ToListAsync();
        }
        // Other repository methods...
    }
}
