using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    internal enum Cargos
    {
        Operador = 1,
        Coordenador = 2,
        Gerente = 3,
        Diretor = 4
    }

    class Pedido
    {
        public Cargos Criador { get; private set; }

        public Pedido(Cargos criador)
        {
            this.Criador = criador;
        }
    }

    abstract class LiberadorPedidos
    {
        public LiberadorPedidos Proximo { get; set; }

        public abstract void LiberarPedido(Pedido pedido);
    }

    class LiberadorDePedidosOperador : LiberadorPedidos
    {
        public override void LiberarPedido(Pedido pedido)
        {
            if (pedido.Criador == Cargos.Operador)
            {
                //liberar o pedido
                Console.WriteLine("liberador pelo Operador");
            }
            else
                Proximo.LiberarPedido(pedido);
        }
    }
    class LiberadorDePedidosCoordenador : LiberadorPedidos
    {
        public override void LiberarPedido(Pedido pedido)
        {
            if (pedido.Criador < Cargos.Coordenador)
            {
                //liberar o pedido
                Console.WriteLine("liberador pelo Coordenador");
            }
            else
                Proximo.LiberarPedido(pedido);
        }
    }
    class LiberadorDePedidosGerente : LiberadorPedidos
    {
        public override void LiberarPedido(Pedido pedido)
        {
            if (pedido.Criador < Cargos.Gerente)
            {
                //liberar o pedido
                Console.WriteLine("liberador pelo Gerente");
            }
            else
                Proximo.LiberarPedido(pedido);
        }
    }
}
