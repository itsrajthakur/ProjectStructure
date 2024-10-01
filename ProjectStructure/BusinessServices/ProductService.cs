using AutoMapper;
using ProjectStructure.Models;
using ProjectStructure.UnitOfWork;
using ProjectStructure.ViewModel;

namespace ProjectStructure.BusinessServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            var products = _unitOfWork._productRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductViewModel>>(products);
        }

        public ProductViewModel GetProductById(int id)
        {
            var product = _unitOfWork._productRepository.GetById(id);
            return _mapper.Map<ProductViewModel>(product);
        }

        public void AddProduct(ProductViewModel product)
        {
            var model = _mapper.Map<Product>(product);
            _unitOfWork._productRepository.Add(model);
            _unitOfWork.SaveAsync().Wait();
        }

        public void UpdateProduct(ProductViewModel product)
        {
            var model = _mapper.Map<Product>(product);
            _unitOfWork._productRepository.Update(model);
            _unitOfWork.SaveAsync().Wait();
        }

        public void DeleteProduct(int id)
        {
            _unitOfWork._productRepository.Delete(id);
            _unitOfWork.SaveAsync().Wait();
        }
    }
}
