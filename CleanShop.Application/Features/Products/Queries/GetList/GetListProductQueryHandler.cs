using AutoMapper;
using CleanShop.Application.Features.Products.Queries.GetList;
using CleanShop.Application.Paging;
using CleanShop.Application.Responses;
using CleanShop.Application.Services.Repositories;
using CleanShop.Domain.Entities;
using MediatR;

namespace CleanShop.Application.Features.products.Queries.GetList
{
    public class GetListProductQueryHandler : IRequestHandler<GetListProductQuery, GetListResponse<GetListProductListItemDTO>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetListProductQueryHandler(IProductRepository ProductRepository, IMapper mapper)
        {
            _productRepository = ProductRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListProductListItemDTO>> Handle(GetListProductQuery request, CancellationToken cancellationToken)
        {
            Paginate<Product> products = await _productRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken,
                withDeleted: true
                );

            GetListResponse<GetListProductListItemDTO> response = _mapper.Map<GetListResponse<GetListProductListItemDTO>>(products);

            return response;
        }
    }
}
