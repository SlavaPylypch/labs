using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDeviceFactory factory = new DeviceFactory();

            IDevice laptop = factory.CreateDevice("laptop", "IProne");
            IDevice netbook = factory.CreateDevice("netbook", "Kiaomi");
            IDevice ebook = factory.CreateDevice("ebook", "Balaxy");
            IDevice smartphone = factory.CreateDevice("smartphone", "IProne");

            Console.WriteLine(laptop.GetDeviceDetails());
            Console.WriteLine(netbook.GetDeviceDetails());
            Console.WriteLine(ebook.GetDeviceDetails());
            Console.WriteLine(smartphone.GetDeviceDetails());
        }
    }
}
