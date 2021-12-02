using CoffeeShop.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DataAccess.Concrete.EntityFramework.Context
{
    public class ApplicationDbContext:DbContext
    {
        //ApplicationDbContext oluşurken options parametresi alır. bu parametrede startup'tan buraya gönderilir.
        //veri tabanı bağlantısı, dbContexte de gönderildi. standart.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
                
        }
        
        //veri tabanı tablo isimleri ve nesne bağlantısı buradan yapılır.
        public DbSet<City> Cities { get; set; }
        public DbSet<Coffee> Coffee { get; set; }
        public DbSet<CoffeeCategory> CoffeeCategory { get; set; }
        public DbSet<CoffeePlace> CoffeePlace { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuCoffee> MenuCoffee { get; set; }
        public DbSet<Region> Region { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //MenuCoffeeye CoffeeId ve MenuId primaryKey tanımlandı.
            modelBuilder.Entity<MenuCoffee>().HasKey(c => new { c.CoffeeId, c.MenuId });

            
        }
    }
}
