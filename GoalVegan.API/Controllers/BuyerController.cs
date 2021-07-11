using GoalVegan.API.Models.ViewModels.BuyerModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult Post([FromBody] CreateBuyerModel createBuyer)
        {
            return CreatedAtAction(nameof(GetById), new { Id = 1 }, createBuyer);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] UpdateBuyerModel updateBuyer)
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
