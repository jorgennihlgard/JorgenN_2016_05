using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JorgenN.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("Store")
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer());
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

    }

    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var store =  new Store()
            { Address = "Kostigen 3", Id = 1, Name = "Stallbutiken", Products = new List<Product>()
                {
                    new Product() {Id = 1, Name = "Hö", Price = 34, ProductNumber = "p-123", ProductInStock = 200, ProductText = "Bästaste höet"},
                    new Product() {Id = 2, Name = "Gräs", Price = 23, ProductNumber = "p-234", ProductInStock = 445, ProductText = "Gräset är grönast här"}
                }
               
            };



            context.Stores.Add(store);
            context.SaveChanges();

        }
    }
}