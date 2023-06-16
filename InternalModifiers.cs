using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifiers
{
    internal class InternalModifiers
    {
        
        int value1;
        int value2;

        public void SetData(int a, int b)
        {
            value1 = a;
            value2 = b;
        }

        public void DisplayData()
        {
            Console.WriteLine("Value 1 is: " + value1);
            Console.WriteLine("Value 2 is: " + value2);
        }
    }

}

