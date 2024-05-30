using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Laptop : IDevice
    {
        private readonly string _brand;

        public Laptop(string brand)
        {
            _brand = brand;
        }

        public string GetDeviceDetails()
        {
            return $"Laptop by {_brand}";
        }
    }
}
