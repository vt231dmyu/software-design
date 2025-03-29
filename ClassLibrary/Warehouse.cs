using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse : IWarehouse
    {
        public List<IProduct> Products { get; private set; }
        public string Unit { get; private set; }
        public DateTime LastDeliveryDate { get; private set; }

        public Warehouse(string unit)
        {
            Products = new List<IProduct>();
            Unit = unit;
            LastDeliveryDate = DateTime.Now;
        }

        public void AddProduct(IProduct product)
        {
            Products.Add(product);
            LastDeliveryDate = DateTime.Now;
        }
        public bool RemoveProduct(string productName, int quantity)
        {
            IProduct product = Products.Find(p => p.Name == productName);
            if (product != null && product.Quantity >= quantity)
            {
                product.ReduceQuantity(quantity);
                if (product.Quantity == 0)
                    Products.Remove(product);
                return true;
            }
            return false;
        }
        public string ShowProducts()
        {
            var result = "Товари на складі:\n";
            if (Products.Count <= 0)
                return result + "На складі пусто.\n";
            foreach (var product in Products)
            {
                result += product;
            }
            return result;
        }
    }
}
