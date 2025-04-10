using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class IProneLaptop : ILaptop
    {
        public void ShowSpecs() => Console.WriteLine("IProne Laptop");
    }
}
