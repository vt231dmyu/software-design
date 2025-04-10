using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class IProneNetbook : INetbook
    {
        public void ShowSpecs() => Console.WriteLine("IProne Netbook");
    }
}
