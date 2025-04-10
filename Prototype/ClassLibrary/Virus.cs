using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Virus : IVirus
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<IVirus> Children { get; set; } = new List<IVirus>();

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
        }

        public IVirus Clone()
        {
            Virus clone = new Virus(Name, Species, Weight, Age);
            foreach (var child in Children)
            {
                clone.Children.Add(child.Clone());
            }
            return clone;
        }

        public void Print(string indent = "")
        {
            Console.WriteLine($"{indent}Name: {Name}, Species: {Species}, Weight: {Weight}, Age: {Age}");
            foreach (var child in Children)
            {
                if (child is Virus virusChild)
                {
                    virusChild.Print(indent + "  ");
                }
            }
        }
    }
}
