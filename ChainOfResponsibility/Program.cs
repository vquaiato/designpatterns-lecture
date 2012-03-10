using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido(Cargos.Coordenador);

            LiberadorPedidos liberador = new LiberadorDePedidosOperador();
            LiberadorPedidos liberadorCoordenador = new LiberadorDePedidosCoordenador();
            LiberadorPedidos liberadorGerente = new LiberadorDePedidosGerente();

            liberador.Proximo = liberadorCoordenador;
            liberadorCoordenador.Proximo = liberadorGerente;
            liberadorGerente.Proximo = liberadorCoordenador;

            liberador.LiberarPedido(pedido);

            Console.ReadKey();
        }
    }
}
