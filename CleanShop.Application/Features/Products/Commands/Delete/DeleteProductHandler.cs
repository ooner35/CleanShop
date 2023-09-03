using AutoMapper;
using CleanShop.Application.Services.Repositories;
using CleanShop.Domain.Entities;
using MediatR;

namespace CleanShop.Application.Features.Products.Commands.Delete
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DeleteProductResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<DeleteProductResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            Product? product = await _productRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            await _productRepository.DeleteAsync(product);

            DeleteProductResponse response = _mapper.Map<DeleteProductResponse>(product);

            return response;
        }
    }
}
