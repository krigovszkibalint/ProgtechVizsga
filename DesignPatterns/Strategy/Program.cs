using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Stratégia: normál rendezés");
            context.SetStrategy(new StrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Stratégia: rendezés visszafelé");
            context.SetStrategy(new StrategyB());
            context.DoSomeBusinessLogic();
            Console.ReadLine();
        }
    }
}
