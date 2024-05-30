using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LightElementNode div = new LightElementNode("div", true, false);
            div.CssClasses.Add("container");

            LightElementNode header = new LightElementNode("h1", true, false);
            header.AddChild(new LightTextNode("Welcome to LightHTML"));

            LightElementNode paragraph = new LightElementNode("p", true, false);
            paragraph.AddChild(new LightTextNode("This is a custom HTML rendering example."));

            LightElementNode img = new LightElementNode("img", false, true);
            img.CssClasses.Add("responsive");

            div.AddChild(header);
            div.AddChild(paragraph);
            div.AddChild(img);

            Console.WriteLine("OuterHTML:");
            Console.WriteLine(div.OuterHTML);
            Console.WriteLine();
            Console.WriteLine("InnerHTML:");
            Console.WriteLine(div.InnerHTML);
        }
    }
}
