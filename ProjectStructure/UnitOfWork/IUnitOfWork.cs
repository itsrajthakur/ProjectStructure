using ProjectStructure.Repository;

namespace ProjectStructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository _productRepository { get; }
        Task SaveAsync();
    }
}
