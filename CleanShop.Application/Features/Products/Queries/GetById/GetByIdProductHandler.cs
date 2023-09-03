using AutoMapper;
using CleanShop.Application.Services.Repositories;
using CleanShop.Domain.Entities;
using MediatR;

namespace CleanShop.Application.Features.Products.Queries.GetById
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQuery, GetByIdProductResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public GetByIdProductQueryHandler(IMapper mapper, IProductRepository ProductRepository)
        {
            _mapper = mapper;
            _productRepository = ProductRepository;
        }

        public async Task<GetByIdProductResponse> Handle(GetByIdProductQuery request, CancellationToken cancellationToken)
        {
            Product? product = await _productRepository.GetAsync(predicate: b => b.Id == request.Id, withDeleted: true, cancellationToken: cancellationToken);

            GetByIdProductResponse response = _mapper.Map<GetByIdProductResponse>(product);

            return response;
        }
    }
}
