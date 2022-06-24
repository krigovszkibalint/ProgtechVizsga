using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    abstract class AbstractClass
    {
        // a template megadja az algoritmus szerkezetét
        public void TemplateMethod()
        {
            this.BaseOperation1();
            this.RequiredOperations1();
            this.BaseOperation2();
            this.Hook1();
            this.RequiredOperation2();
            this.BaseOperation3();
            this.Hook2();
        }

        // ezeknek már van implementációjuk
        protected void BaseOperation1()
        {
            Console.WriteLine("AbstractClass: végzi a munka nagyrészét\n");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("AbstractClass: de hagyja, hogy az alosztályok felülírjanak néhány műveletet\n");
        }

        protected void BaseOperation3()
        {
            Console.WriteLine("AbstractClass: de még mindig ő végzi a munka nagy részét\n");
        }

        // ezeket gyerek osztályokban kell implementálni
        protected abstract void RequiredOperations1();

        protected abstract void RequiredOperation2();

        // hook, a gyerek osztályok felülírhatják, de nem kötelező,
        // mert a hookoknak van egy default implementációja
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }
}
