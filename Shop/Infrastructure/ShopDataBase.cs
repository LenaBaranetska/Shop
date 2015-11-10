using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using domainShop;

namespace Shop.Infrastructure
{
    public class ShopDataBase : DbContext
    {
        public ShopDataBase()
            : base("DefaultConnection")
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}