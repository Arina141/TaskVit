﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Box<T>
    {

        public Box(T item)
        {
            Item = item;
        }

        public T Item { get; set; }
    }
}
