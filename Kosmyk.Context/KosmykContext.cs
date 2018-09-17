using Kosmyk.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosmyk.Context
{
    public class KosmykContext : DbContext
    {
        private DbSet<Product> products;
        private DbSet<Purchase> purchases;

        public DbSet<Product> Products { get => products; set => products = value; }
        public DbSet<Purchase> Purchases { get => purchases; set => purchases = value; }
    }
}
