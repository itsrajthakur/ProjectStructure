using ProjectStructure.Models;

namespace ProjectStructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return _dbContext.Product.ToList();
        }

        public Product GetById(int id)
        {
            return _dbContext.Product.Find(id);
        }

        public void Add(Product product)
        {
            _dbContext.Product.Add(product);
        }

        public void Update(Product product)
        {
            _dbContext.Product.Update(product);
        }

        public void Delete(int id)
        {
            var product = _dbContext.Product.Find(id);
            if (product != null)
            {
                _dbContext.Product.Remove(product);
            }
        }
    }
}
