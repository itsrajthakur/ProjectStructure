using ProjectStructure.ViewModel;

namespace ProjectStructure.BusinessServices
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetAllProducts();
        ProductViewModel GetProductById(int id);
        void AddProduct(ProductViewModel product);
        void UpdateProduct(ProductViewModel product);
        void DeleteProduct(int id);
    }
}
