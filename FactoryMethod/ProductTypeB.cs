﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class ProductTypeB : Product
    {
        internal override string Result()
        {
            return "Result Type B";
        }
    }
}
