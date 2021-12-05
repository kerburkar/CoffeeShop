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
    public class CoffeePlaceController : ControllerBase
    {
        private readonly ICoffeePlaceService _coffeePlaceService;
        public CoffeePlaceController(ICoffeePlaceService coffeePlaceService)
        {
            _coffeePlaceService = coffeePlaceService;
        }

        [HttpGet("getcoffeePlaces")]
        public ActionResult GetCoffeePlaces()
        {
            var coffeePlaces = _coffeePlaceService.GetCoffeePlaces();
            return Ok(coffeePlaces);

        }

        [HttpGet("getcoffeePlace/{id}")]
        public ActionResult GetCoffeePlace(int id)
        {
            var coffeePlace = _coffeePlaceService.GetCoffeePlace(id);
            return Ok(coffeePlace);

        }
    }
}
