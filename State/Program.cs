using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra();
            string status1 = compra.ObterInformacoesDaCompra();
            compra.MudarStatus();
            string status2 = compra.ObterInformacoesDaCompra();
            compra.MudarStatus();
            string status3 = compra.ObterInformacoesDaCompra();

            Console.WriteLine(status1);
            Console.WriteLine(status2);
            Console.WriteLine(status3);

            Console.ReadKey();
        }
    }
}
