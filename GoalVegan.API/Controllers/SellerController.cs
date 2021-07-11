using GoalVegan.API.Models.SellerModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalVegan.API.Controllers
{
    [Route("api/seller")]
    public class SellerController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateSellerModel createSellerModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createSellerModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateSellerModel updateSellerModel)
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


        public IActionResult PaymentSeller(int id)
        {
            return NoContent();
        }
    }
}
