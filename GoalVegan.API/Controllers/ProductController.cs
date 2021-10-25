using GoalVegan.Application.Queries.GetAllProducts;
using GoalVegan.Application.Queries.GetProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Controllers
{
    [Route("api/products")]
    public class ProductController:ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var getAllProductsQuery = new GetAllProductsQuery(query);
            var products = await _mediator.Send(getAllProductsQuery);

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetById(int id)
        {
            var getProductByIdQuery = new GetProductByIdQuery(id);
            var product = await _mediator.Send(getProductByIdQuery);

            return Ok(product);
        }


    }
}
