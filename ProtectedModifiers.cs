using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessModifiers
{

    public class Base
    {
        protected int num1;
    }

    public class Derived : Base
    {
        public int num2;

        public int Add()
        {
            num1 = num2;

            return num1 + num2;

        }
    }
}
