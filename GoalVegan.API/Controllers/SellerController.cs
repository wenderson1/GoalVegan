
using GoalVegan.Application.Commands.CreateSeller;
using GoalVegan.Application.Commands.DeleteSeller;
using GoalVegan.Application.Commands.UpdateSeller;
using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Seller;
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

        [HttpPut("{id/login")]
        public IActionResult Login(int id, [FromBody] SellerLoginModel login)
        {
            return NoContent();
        }
    }
}
