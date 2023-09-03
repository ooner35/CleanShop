using CleanShop.Application.Features.Products.Commands.Create;
using CleanShop.Application.Features.Products.Commands.Delete;
using CleanShop.Application.Features.Products.Commands.Update;
using CleanShop.Application.Features.Products.Queries.GetById;
using CleanShop.Application.Features.Products.Queries.GetList;
using CleanShop.Application.Requests;
using CleanShop.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProductCommand createProductCommand)
        {
            CreateProductResponse response = await _mediator.Send(createProductCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListProductQuery getListProductQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListProductListItemDTO> response = await _mediator.Send(getListProductQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdProductQuery getByIdProductQuery = new() { Id = id };

            GetByIdProductResponse response = await _mediator.Send(getByIdProductQuery);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductCommand updateProductCommand)
        {
            UpdateProductResponse response = await _mediator.Send(updateProductCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeleteProductResponse response = await _mediator.Send(new DeleteProductCommand { Id = id });

            return Ok(response);
        }
    }
}
