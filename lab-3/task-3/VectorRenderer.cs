﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as lines");
        }
    }
}
