using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass2: Operation1 implementálva\n");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass2: Operation2 implementálva\n");
        }

        protected override void Hook1()
        {
            Console.WriteLine("ConcreteClass2: Hook1 felülírva\n");
        }
    }
}
