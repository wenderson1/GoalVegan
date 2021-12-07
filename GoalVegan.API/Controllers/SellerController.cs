
using GoalVegan.Application.Commands;
using GoalVegan.Application.Commands.CancelOrder;
using GoalVegan.Application.Commands.CreateProduct;
using GoalVegan.Application.Commands.CreateSeller;
using GoalVegan.Application.Commands.DeleteProduct;
using GoalVegan.Application.Commands.DeleteSeller;
using GoalVegan.Application.Commands.DeliveredOrder;
using GoalVegan.Application.Commands.SentOrder;
using GoalVegan.Application.Commands.UpdateProduct;
using GoalVegan.Application.Commands.UpdateSeller;
using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Seller;
using GoalVegan.Application.Queries.GetOrdersBySeller;
using GoalVegan.Application.Queries.GetOrderSeller;
using GoalVegan.Application.Queries.GetProduct;
using GoalVegan.Application.Queries.GetProductsBySeller;
using GoalVegan.Application.Queries.GetSeller;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Controllers
{
    [Route("api/sellers")]
    public class SellerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SellerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetSellerByIdQuery(id);
            var seller = await _mediator.Send(query);

            if (seller == null) return NotFound();

            return Ok(seller);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateSellerCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateSellerCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteSellerCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpGet("{id}/orders")]

        public async Task<IActionResult> GetOrders(int idSeller)
        {
            var getOrdersBySeller = new GetOrderBySellerQuery(idSeller);
            var orders = await _mediator.Send(getOrdersBySeller);
            return Ok(orders);
        }

        [HttpGet("{id}/order/{orderId}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var getOrderByIdSellerQuery = new GetOrderSellerQuery(id);
            var order = await _mediator.Send(getOrderByIdSellerQuery);
            return Ok(order);
        }

        [HttpPut("{id}/order/{orderId}")]
        public async Task<IActionResult> CancelOrder(int id)
        {
            var command = new CancelOrderCommand(id);
            await _mediator.Send(command);
            return Ok("Pedido Cancelado");
        }
        [HttpPut("{id}/order/billedOrder/{orderId}")]
        public async Task<IActionResult> BilledOrder(int id)
        {
            var command = new BilledOrderCommand(id);
            await _mediator.Send(command);
            return Ok("Pedido Faturado");
        }

        [HttpPut("{id}/order/orderSent/{orderId}")]
        public async Task<IActionResult> SentOrder(int id)
        {
            var command = new SentOrderCommand(id);
            await _mediator.Send(command);
            return Ok("Pedido Enviado");
        }

        [HttpPut("{id}/order/deliveredOrder/{orderId}")]
        public async Task<IActionResult> DeliveredOrder(int id)
        {
            var command = new DeliveredOrderCommand(id);
            await _mediator.Send(command);
            return Ok("Pedido Entregue");
        }

        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetProductsBySeller(int idSeller)
        {
            var getProductsBySeller = new GetProductsBySellerQuery(idSeller);
            var products = await _mediator.Send(getProductsBySeller);
            return Ok(products);
        }


        [HttpGet("{id}/product/{idProduct}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var getProductByid = new GetProductByIdQuery(id);
            var product = await _mediator.Send(getProductByid);
            return Ok(product);
        }

        [HttpPost("{id}/createProduct")]
        public async Task<IActionResult> CreateProduct(int id, [FromBody] CreateProductCommand command)
        {
            await _mediator.Send(command);
            return CreatedAtAction(nameof(GetProductById), new { id = id }, command);
        }

        [HttpPut("{id}/updateProduct/{idProduct}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody]UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}/deleteProduct/{idProduct}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var command = new DeleteProductCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}/login")]
        public async Task<IActionResult> Login([FromBody] SellerLoginModel command)
        {
            var sellerLoginViewModel = await _mediator.Send(command);

            if (sellerLoginViewModel == null)
                return BadRequest("Usuário não encontrado");

            return Ok(sellerLoginViewModel);
        }
    }
}
