using CleanShop.Application.Requests;
using CleanShop.Application.Responses;
using MediatR;

namespace CleanShop.Application.Features.Products.Queries.GetList
{
    public class GetListProductQuery : IRequest<GetListResponse<GetListProductListItemDTO>>
    {
        public PageRequest PageRequest { get; set; }
    }
}
