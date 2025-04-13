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
            IRenderer vectorRenderer = new VectorRenderer();
            IRenderer rasterRenderer = new RasterRenderer();

            Shape circle = new Circle(rasterRenderer);
            Shape square = new Square(vectorRenderer);
            Shape triangle = new Triangle(rasterRenderer);

            circle.Draw();
            square.Draw();
            triangle.Draw();
        }
    }
}
