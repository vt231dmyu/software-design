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
            ITechFactory iProneFactory = new IProneFactory();
            ILaptop iProneLaptop = iProneFactory.CreateLaptop();
            INetbook iProneNetbook = iProneFactory.CreateNetbook();
            IEBook iProneEBook = iProneFactory.CreateEBook();
            ISmartphone iProneSmartphone = iProneFactory.CreateSmartphone();

            iProneLaptop.ShowSpecs();
            iProneNetbook.ShowSpecs();
            iProneEBook.ShowSpecs();
            iProneSmartphone.ShowSpecs();

            Console.WriteLine("\n=========================\n");

            ITechFactory kiaomiFactory = new KiaomiFactory();
            ILaptop kiaomiLaptop = kiaomiFactory.CreateLaptop();
            INetbook kiaomiNetbook = kiaomiFactory.CreateNetbook();
            IEBook kiaomiEBook = kiaomiFactory.CreateEBook();
            ISmartphone kiaomiSmartphone = kiaomiFactory.CreateSmartphone();

            kiaomiLaptop.ShowSpecs();
            kiaomiNetbook.ShowSpecs();
            kiaomiEBook.ShowSpecs();
            kiaomiSmartphone.ShowSpecs();

            Console.WriteLine("\n=========================\n");

            ITechFactory balaxyFactory = new BalaxyFactory();
            ILaptop balaxyLaptop = balaxyFactory.CreateLaptop();
            INetbook balaxyNetbook = balaxyFactory.CreateNetbook();
            IEBook balaxyEBook = balaxyFactory.CreateEBook();
            ISmartphone balaxySmartphone = balaxyFactory.CreateSmartphone();

            balaxyLaptop.ShowSpecs();
            balaxyNetbook.ShowSpecs();
            balaxyEBook.ShowSpecs();
            balaxySmartphone.ShowSpecs();
        }
    }
}
