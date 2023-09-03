using MediatR;

namespace CleanShop.Application.Features.Products.Commands.Create
{
    public class CreateProductCommand : IRequest<CreateProductResponse>
    {
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        public int Quantity { get; set; }
    }
}
