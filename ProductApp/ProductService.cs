using ProductApp.Models;

namespace ProductApp
{
    public class ProductServices : IProductServices
    {
        private readonly List<Product> _products;

        public ProductServices()
        {
            // Ініціалізація тестових даних
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop", Price = 1200 },
            new Product { Id = 2, Name = "Mouse", Description = "Wireless mouse", Price = 25 },
            new Product { Id = 3, Name = "Keyboard", Description = "Mechanical keyboard", Price = 75 }
        };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = GetProductById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
            }
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
