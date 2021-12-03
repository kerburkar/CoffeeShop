using CoffeeShop.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("getcities")]
        public ActionResult GetCities()
        {
            var cities = _cityService.GetCities();
            return Ok(cities);

        }

        [HttpGet("getcity/{id}")]
        public ActionResult GetCity(int id)
        {
            var city = _cityService.GetCity(id);
            return Ok(city);

        }



    }
}
