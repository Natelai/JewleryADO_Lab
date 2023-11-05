using AutoMapper;
using Domain.Entities;
using JewleryADO_Lab.ViewModels;
using System.Data;

namespace DesignProjectsManagementStudio.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<OrderViewModel, Order>();
            CreateMap<MaterialViewModel, Material>();
            CreateMap<GoodViewModel, Good>();

            CreateMap<Client, ClientViewModel>();
            CreateMap<Order, OrderViewModel>();
            CreateMap<Material, MaterialViewModel>();
            CreateMap<Good, GoodViewModel>();
        }
    }
}
