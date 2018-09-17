using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosmyk.Models
{
    public class Product
    {
        private int productId;
        private string name;
        private string brand;
        private DateTime createdAt;
        private DateTime updatedAt;

        public string Name { get => name; set => name = value; }
        public int ProductId { get => productId; set => productId = value; }
        public string Brand { get => brand; set => brand = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}
