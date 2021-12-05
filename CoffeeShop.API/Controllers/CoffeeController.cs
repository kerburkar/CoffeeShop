using CoffeeShop.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeService _coffeeService;
        public CoffeeController(ICoffeeService coffeeService)
        {
            _coffeeService = coffeeService;
        }

        [HttpGet("getcoffees")]
        public ActionResult GetCoffees()
        {
            var coffees = _coffeeService.GetCoffees();
            return Ok(coffees);

        }

        [HttpGet("getcoffee/{id}")]
        public ActionResult GetCoffee(int id)
        {
            var coffee = _coffeeService.GetCoffee(id);
            return Ok(coffee);

        }
    }
}
