using CoffeeShop.DataAccess.Abstract;
using CoffeeShop.DataAccess.Concrete.EntityFramework.Context;
using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DataAccess.Concrete.EntityFramework
{
    public class RegionRepository : BaseRepository<Region>, IRegionRepository
    {
        public RegionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
