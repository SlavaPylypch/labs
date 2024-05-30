using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Smartphone : IDevice
    {
        private readonly string _brand;

        public Smartphone(string brand)
        {
            _brand = brand;
        }

        public string GetDeviceDetails()
        {
            return $"Smartphone by {_brand}";
        }
    }
}
