using AutoMapper;
using ProjectStructure.Models;
using ProjectStructure.ViewModel;

namespace ProjectStructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
