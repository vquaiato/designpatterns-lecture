using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista de passageiros

            //lista de trechos

            //lista de pagamentos

            CiaAerea cia = new ViniciusAirLines();

            Reserva reserva = CriarReserva(cia);
        }
        static Reserva CriarReserva(CiaAerea ciaAerea)
        {
            //iterando em cada passageiro
            ciaAerea.CriarPassageiro("pax");

            //iterando em cada trecho
            ciaAerea.CriarTrecho("origem", "destino", DateTime.Now);

            //iterando em cada pgto
            ciaAerea.CriarPagamento("pgto");

            return ciaAerea.ObterReserva();
        }
    }
}
