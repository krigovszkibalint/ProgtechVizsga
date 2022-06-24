using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1: Operation1 implementálva\n");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1: Operation2 implementálva\n");
        }
    }
}
