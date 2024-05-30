﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Netbook : IDevice
    {
        private readonly string _brand;

        public Netbook(string brand)
        {
            _brand = brand;
        }

        public string GetDeviceDetails()
        {
            return $"Netbook by {_brand}";
        }
    }

}
