using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using JorgenN.Models;

namespace JorgenN
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (var ctx = new StoreContext())
            {
                var store = new Store()
                {
                    Address = "Häststigen 7", Name = "Hästbutiken", Id = 2, Products = new List<Product>()
                    {
                        new Product() {Id = 3, Name = "Värmelampa", Price = 256, ProductNumber = "p-788", ProductInStock = 55, ProductText = "Varmt och gott"},
                         new Product() {Id = 4, Name = "Torkad Rotfukt", Price = 23, ProductNumber = "p-899", ProductInStock = 455,ProductText = "Finaste frukterna"}
                    }
                };

                ctx.Stores.Add(store);
                ctx.SaveChanges();
            }
        }
    }
}
