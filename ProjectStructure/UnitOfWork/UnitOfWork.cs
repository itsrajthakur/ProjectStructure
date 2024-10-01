using ProjectStructure.Models;
using ProjectStructure.Repository;

namespace ProjectStructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public IProductRepository _productRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _productRepository = new ProductRepository(_dbContext);
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
