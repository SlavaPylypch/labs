using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class EBook : IDevice
    {
        private readonly string _brand;

        public EBook(string brand)
        {
            _brand = brand;
        }

        public string GetDeviceDetails()
        {
            return $"EBook by {_brand}";
        }
    }
}
