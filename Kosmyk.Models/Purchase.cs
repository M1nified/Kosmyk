using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosmyk.Models
{
    public class Purchase
    {
        private int purchaseId;
        private int amount;
        private int pricePerUnit;

        public Product Product { get; set; }
        public int Amount { get => amount; set => amount = value; }
        public int PurchaseId { get => purchaseId; set => purchaseId = value; }
        public int PricePerUnit { get => pricePerUnit; set => pricePerUnit = value; }
    }
}
