using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "pg1513.txt";
            string solutionRootPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", ".."));
            string filePath = Path.Combine(solutionRootPath, fileName);

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found at path: {filePath}");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            long memoryBefore = GC.GetTotalMemory(true);

            var body = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);
            bool isFirstLine = true;

            foreach (var lineRaw in lines)
            {
                var line = lineRaw.TrimEnd();
                if (string.IsNullOrWhiteSpace(line)) continue;

                LightElementNode templateTag;

                if (isFirstLine)
                {
                    templateTag = new LightElementNode("h1", DisplayType.Block, ClosingType.Pair);
                    isFirstLine = false;
                }
                else if (line.StartsWith(" "))
                {
                    templateTag = new LightElementNode("blockquote", DisplayType.Block, ClosingType.Pair);
                }
                else if (line.Length < 20)
                {
                    templateTag = new LightElementNode("h2", DisplayType.Block, ClosingType.Pair);
                }
                else
                {
                    templateTag = new LightElementNode("p", DisplayType.Block, ClosingType.Pair);
                }

                templateTag.AddChild(new LightTextNode(line.Trim()));
                body.AddChild(templateTag);
            }

            long memoryAfter = GC.GetTotalMemory(true);
            long memoryUsed = memoryAfter - memoryBefore;

            Console.WriteLine("=== Generated OuterHTML ===");
            Console.WriteLine(body.OuterHTML);

            Console.WriteLine("\n=== Number of unique HTML tags (Flyweight) ===");
            Console.WriteLine(FlyweightFactory.Count);

            Console.WriteLine("\n=== Number of all nodes in the tree ===");
            Console.WriteLine(CountAllNodes(body));

            Console.WriteLine("\n=== Memory used ===");
            Console.WriteLine($"{memoryUsed} bytes ({memoryUsed / 1024.0:F2} kilobytes)");
        }

        static int CountAllNodes(LightNode node)
        {
            int count = 1;

            if (node is LightElementNode element)
            {
                foreach (var child in element.Children)
                {
                    count += CountAllNodes(child);
                }
            }

            return count;
        }
    }
}
