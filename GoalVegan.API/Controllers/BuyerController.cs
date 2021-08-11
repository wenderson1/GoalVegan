using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Buyer;
using Microsoft.AspNetCore.Mvc;

namespace GoalVegan.API.Controllers
{
    [Route("api/buyers")]
    public class BuyerController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateBuyerInputModel createBuyer)
        {
            return CreatedAtAction(nameof(GetById), new { Id = 1 }, createBuyer);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] UpdateBuyerInputModel updateBuyer)
        {
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
