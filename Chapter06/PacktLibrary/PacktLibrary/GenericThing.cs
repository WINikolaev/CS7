﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public class GenericThing<T> where T : IComparable, IFormattable
    {
        public T Data = default(T);
        public string Process(string input)
        {
            if (Data.ToString().CompareTo(input) == 0)
            {
                return Data.ToString() + Data.ToString();
            }
            else
            {
                return Data.ToString();
            }
        }
    }
}