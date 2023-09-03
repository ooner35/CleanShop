using AutoMapper;
using CleanShop.Application.Services.Repositories;
using CleanShop.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanShop.Application.Features.Products.Commands.Create
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request);
            product.Id = Guid.NewGuid();

            var result = await _productRepository.AddAsync(product);

            CreateProductResponse response = _mapper.Map<CreateProductResponse>(result);

            return response;
        }
    }
}
