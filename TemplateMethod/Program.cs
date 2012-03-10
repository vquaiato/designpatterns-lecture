using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Pagamento avista = new PagamentoAVista();
            Pagamento parcelado = new PagamentoParcelado();

            avista.CalcularTotal();
            parcelado.CalcularTotal();
        }
    }
}
