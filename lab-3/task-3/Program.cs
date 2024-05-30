using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRenderer vectorRenderer = new VectorRenderer();
            IRenderer rasterRenderer = new RasterRenderer();

            Shape circleVector = new Circle(vectorRenderer);
            Shape squareVector = new Square(vectorRenderer);
            Shape triangleVector = new Triangle(vectorRenderer);

            Shape circleRaster = new Circle(rasterRenderer);
            Shape squareRaster = new Square(rasterRenderer);
            Shape triangleRaster = new Triangle(rasterRenderer);

            circleVector.Draw();
            squareVector.Draw();
            triangleVector.Draw();

            circleRaster.Draw();
            squareRaster.Draw();
            triangleRaster.Draw();
            Console.ReadKey();
        }
    }
}
