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
            var ul = new LightElementNode("ul", DisplayType.Block, ClosingType.Pair);
            ul.AddClass("list");

            var li1 = new LightElementNode("li", DisplayType.Block, ClosingType.Pair);
            li1.AddChild(new LightTextNode("First point"));
            li1.AddClass("list__item");
            ul.AddChild(li1);

            var li2 = new LightElementNode("li", DisplayType.Block, ClosingType.Pair);
            li2.AddChild(new LightTextNode("Second point"));
            li2.AddClass("list__item");
            li2.AddClass("active");
            ul.AddChild(li2);

            var li3 = new LightElementNode("li", DisplayType.Block, ClosingType.Pair);
            li3.AddChild(new LightTextNode("Third point"));
            li3.AddClass("list__item");
            ul.AddChild(li3);

            Console.WriteLine("=== OuterHTML ===");
            Console.WriteLine(ul.OuterHTML);

            Console.WriteLine("\n=== InnerHTML ===");
            Console.WriteLine(ul.InnerHTML);
        }
    }
}
