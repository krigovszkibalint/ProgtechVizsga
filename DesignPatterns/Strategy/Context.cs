using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        // a context hivatkozik az egyik stratégiára
        private IStrategy _strategy;

        public Context()
        { }

        // a context a konstruktoron keresztül elfogadja a stratégiát,
        // és settert is biztosít futás közbeni változtatásra
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // a stratégia objektumok futás közben is cserélhetők
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // delegáció a stratégia objektumnak az algoritmus többféle implementálása helyett
        public void DoSomeBusinessLogic()
        {
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
