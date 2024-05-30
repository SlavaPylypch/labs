using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace task_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();

            string[] lines = File.ReadAllLines("book.txt");

            LightElementNode root = factory.GetElement("div", true, false);

            foreach (string line in lines)
            {
                LightElementNode element;

                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }

                if (line.Length < 20)
                {
                    element = factory.GetElement("h2", true, false);
                }
                else if (line.StartsWith(" "))
                {
                    element = factory.GetElement("blockquote", true, false);
                }
                else
                {
                    element = factory.GetElement("p", true, false);
                }

                element.AddChild(new LightTextNode(line));
                root.AddChild(element);

                element.AddEventListener("click", () => Console.WriteLine($"{line} was clicked."));
                element.AddEventListener("mouseover", () => Console.WriteLine($"{line} was hovered over."));
            }

            string outerHTML = root.OuterHTML;


            string outputPath = "output.html";
            File.WriteAllText(outputPath, outerHTML);
            Console.WriteLine($"OuterHTML saved to {outputPath}");

            Console.WriteLine("\nDispatching events:");
            root.DispatchEvent("click");
            root.DispatchEvent("mouseover");

            long memoryUsage = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory usage: {memoryUsage} bytes");
        }
    }
}
