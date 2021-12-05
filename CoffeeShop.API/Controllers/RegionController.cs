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
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;
        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet("getregions")]
        public ActionResult GetRegions()
        {
            var regions = _regionService.GetRegions();
            return Ok(regions);

        }

        [HttpGet("getregion/{id}")]
        public ActionResult GetRegion(int id)
        {
            var region = _regionService.GetRegion(id);
            return Ok(region);

        }
    }
}
