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
            IHero warrior = new Warrior();
            warrior = new ArmorDecorator(warrior);
            warrior = new WeaponDecorator(warrior);
            warrior = new ArtifactDecorator(warrior);
            Console.WriteLine(warrior.GetDescription());

            IHero mage = new Mage();
            mage = new ArmorDecorator(mage);
            mage = new ArtifactDecorator(mage);
            Console.WriteLine(mage.GetDescription());

            IHero palladin = new Palladin();
            palladin = new WeaponDecorator(palladin);
            Console.WriteLine(palladin.GetDescription());
        }
    }
}
