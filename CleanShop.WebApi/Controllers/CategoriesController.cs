using CleanShop.Application.Features.Categories.Commands.Create;
using CleanShop.Application.Features.Categories.Commands.Delete;
using CleanShop.Application.Features.Categories.Commands.Update;
using CleanShop.Application.Features.Categories.Queries.GetById;
using CleanShop.Application.Features.Categories.Queries.GetList;
using CleanShop.Application.Requests;
using CleanShop.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            CreateCategoryResponse response = await _mediator.Send(createCategoryCommand);

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListCategoryQuery getListCategoryQuery = new() { PageRequest = pageRequest };

            GetListResponse<GetListCategoryListItemDTO> response = await _mediator.Send(getListCategoryQuery);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdCategoryQuery getByIdCategoryQuery = new() { Id = id };

            GetByIdCategoryResponse response = await _mediator.Send(getByIdCategoryQuery);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryCommand updateCategoryCommand)
        {
            UpdateCategoryResponse response = await _mediator.Send(updateCategoryCommand);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeleteCategoryResponse response = await _mediator.Send(new DeleteCategoryCommand { Id = id });

            return Ok(response);
        }
    }
}
