
using GoalVegan.Application.InputModel;
using GoalVegan.Application.InputModel.Seller;
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
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateSellerInputModel createSellerModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createSellerModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateInputSellerModel updateSellerModel)
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
