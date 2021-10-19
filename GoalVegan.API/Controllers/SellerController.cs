
using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Seller;
using GoalVegan.Application.Queries.GetSeller;
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
        private readonly IMediatR _mediator;
        public SellerController(MediatR _medi)

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public async  IActionResult Post([FromBody] CreateSellerInputModel createSellerModel)
        {
            if (!ModelState.IsValid)
            {
                var messages = ModelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(messages);
            }
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = id }, createSellerModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateSellerInputModel updateSellerModel)
        {
            if (updateSellerModel.Email.Length > 30)
            {
                return BadRequest();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/order/{idOrder}")]
        public IActionResult AddBalance(int id, int idOrder)
        {
            return NoContent();
        }

        [HttpPut("{id}/payment/{idOrder}")]
        public IActionResult PaymentSeller(int id)
        {
            return NoContent();
        }

        [HttpPut("{id/login")]
        public IActionResult Login(int id, [FromBody] SellerLoginModel login)
        {
            return NoContent();
        }
    }
}
