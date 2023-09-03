using AutoMapper;
using CleanShop.Application.Features.Products.Commands.Create;
using CleanShop.Application.Features.Products.Commands.Delete;
using CleanShop.Application.Features.Products.Commands.Update;
using CleanShop.Application.Features.Products.Queries.GetById;
using CleanShop.Application.Features.Products.Queries.GetList;
using CleanShop.Application.Paging;
using CleanShop.Application.Responses;
using CleanShop.Domain.Entities;

namespace CleanShop.Application.Features.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, CreateProductResponse>().ReverseMap();

            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Product, UpdateProductResponse>().ReverseMap();

            CreateMap<Product, DeleteProductCommand>().ReverseMap();
            CreateMap<Product, DeleteProductResponse>().ReverseMap();

            CreateMap<Product, GetListProductListItemDTO>().ReverseMap();
            CreateMap<Product, GetByIdProductResponse>().ReverseMap();
            CreateMap<Paginate<Product>, GetListResponse<GetListProductListItemDTO>>().ReverseMap();
        }
    }
}
