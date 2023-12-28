using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Creator
    {
        internal const int valueA = 1;
        internal const int valueB = 2;

        internal static Product Create(int type)
        {
            switch (type)
            {
                case valueA: return new ProductTypeA();
                case valueB: return new ProductTypeB();
                default: return null;
            }
        }
    }
}
