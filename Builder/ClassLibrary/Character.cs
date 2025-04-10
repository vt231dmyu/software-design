using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Character
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public List<string> Clothes { get; set; } = new List<string>();
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Deeds { get; set; } = new List<string>();

        public override string ToString()
        {
            return 
                $"--- {Type} ---\n" +
                $"Name: {Name}\n" +
                $"Height: {Height}\n" +
                $"Body Type: {BodyType}\n" +
                $"Hair Color: {HairColor}\n" +
                $"Eye Color: {EyeColor}\n" +
                $"Clothes: {string.Join(", ", Clothes)}\n" +
                $"Inventory: {string.Join(", ", Inventory)}\n" +
                $"Deeds: {string.Join(", ", Deeds)}\n";
        }
    }
}
