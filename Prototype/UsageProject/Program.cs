using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IVirus grandParent = new Virus("Alpha", "Covid", 0.002, 1);
            IVirus parent1 = new Virus("Beta", "Covid", 0.05, 3);
            IVirus parent2 = new Virus("Gamma", "Covid", 0.01, 2);
            IVirus child1 = new Virus("Delta", "Covid", 0.008, 1);
            IVirus child2 = new Virus("Epsilon", "Covid", 0.07, 5);

            if (parent1 is Virus p1) p1.Children.Add(child1);
            if (parent2 is Virus p2) p2.Children.Add(child2);
            if (grandParent is Virus gp)
            {
                gp.Children.Add(parent1);
                gp.Children.Add(parent2);

                Console.WriteLine("Original:");
                gp.Print();

                IVirus clone = gp.Clone();
                Console.WriteLine("\nClone:");
                if (clone is Virus clonedVirus)
                {
                    clonedVirus.Print();
                }
            }
        }
    }
}
