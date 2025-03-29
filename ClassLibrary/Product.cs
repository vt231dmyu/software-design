using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product : IProduct
    {
        public string Name { get; private set; }
        public IMoney Price { get; private set; }
        public int Quantity { get; private set; }
        public Product(string name, IMoney price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public IMoney ReducePrice(int whole, int fractional)
        {
            Price.SetParts(Price.WholePart - whole, Price.FractionalPart - fractional);
            return Price;
        }
        public int ReduceQuantity(int quantity) 
        {
            if (Quantity > 0)
                Quantity -= quantity;
            return Quantity;
        }
        public override string ToString()
        {
            return $"Товар: {Name}, Ціна: {Price}, Кількість: {Quantity}\n";
        }
    }
}
