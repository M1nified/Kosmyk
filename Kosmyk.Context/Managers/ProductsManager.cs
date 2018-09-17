using Kosmyk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosmyk.Context.Managers
{
    public class ProductsManager
    {
        public List<Product> GetProducts()
        {
            using (var db = new KosmykContext())
            {
                var list = db.Products.AsParallel().OrderBy(x => x.Name).ToList();
                return list;
            }
        }
    }
}
