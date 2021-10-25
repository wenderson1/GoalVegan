using GoalVegan.Application.Commands.CancelOrder;
using GoalVegan.Application.Commands.CreateBuyer;
using GoalVegan.Application.Commands.CreateOrder;
using GoalVegan.Application.Commands.DeleteBuyer;
using GoalVegan.Application.Commands.UpdateBuyer;
using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Buyer;
using GoalVegan.Application.Queries.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GoalVegan.API.Controllers
{
    [Route("api/buyers")]
    public class BuyerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BuyerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetByIdBuyerQuery(id);

            var buyer = await _mediator.Send(query);

            if (buyer == null) return NotFound();

            return Ok(buyer);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBuyerCommand command, IMediator mediator)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateBuyerCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteBuyerCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPost("{id}/createOrder")]
        public async Task<IActionResult> CreateOrder(int id, [FromBody] CreateOrderCommand command)
        {
            await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id },command);
        }

        [HttpPut("{id}/cancelOrder/{idOrder}")]
        public async Task<IActionResult> CancelOrder(int id)
        {
            var command = new CancelOrderCommand(id);
            await _mediator.Send(command);
            return Ok("Pedido Cancelado");
        }

        [HttpGet("{id}/orders")]
        public async Task<IActionResult> GetOrders()
        {

        }
    }
}
