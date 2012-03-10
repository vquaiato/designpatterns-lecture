using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrategyPesoIdeal pesoHomem = new PesoIdealHomens();
            IStrategyPesoIdeal pesoMulher = new PesoIdealMulheres();

            CalculaPeso(pesoHomem);
            CalculaPeso(pesoMulher);

            Console.ReadKey();
        }

        static void CalculaPeso(IStrategyPesoIdeal calculador)
        {
            Console.WriteLine("Peso: {0}", calculador.PesoIdeal(90, 1.70f));
        }
    }
}
