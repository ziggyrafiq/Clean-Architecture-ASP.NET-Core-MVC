using ZRCleanArchitectureApp.Domain.Entities;
using ZRCleanArchitectureApp.Domain.Interfaces;

namespace ZRCleanArchitectureApp.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        // Add other business logic methods here
    }
}
