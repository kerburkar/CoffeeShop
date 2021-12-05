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
    public class CoffeeCategoryController : ControllerBase
    {
        private readonly ICoffeeCategoryService _coffeeCategoryService;
        public CoffeeCategoryController(ICoffeeCategoryService coffeeCategoryService)
        {
            _coffeeCategoryService = coffeeCategoryService;
        }

        [HttpGet("getcoffeeCategories")]
        public ActionResult GetCoffeeCategories()
        {
            var coffeeCategories = _coffeeCategoryService.GetCoffeeCategories();
            return Ok(coffeeCategories);

        }

        [HttpGet("getcoffeeCategory/{id}")]
        public ActionResult GetCoffeeCategory(int id)
        {
            var coffeeCategory = _coffeeCategoryService.GetCoffeeCategory(id);
            return Ok(coffeeCategory);

        }
    }
}
