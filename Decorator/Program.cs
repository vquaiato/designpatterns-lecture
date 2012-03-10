using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Vinicius";

            ITexto textoPlano = new TextoPlano(texto);

            ITexto negrito = new Negrito(textoPlano);
            
            ITexto negritoItalico = new Negrito(new Italico(textoPlano));
            
            ITexto sublinhadoNegrito = new Sublinhado(negrito);

            Console.WriteLine(textoPlano.Exibir());
            Console.WriteLine(negrito.Exibir());
            Console.WriteLine(negritoItalico.Exibir());
            Console.WriteLine(sublinhadoNegrito.Exibir());

            Console.ReadKey();
        }
    }
}
