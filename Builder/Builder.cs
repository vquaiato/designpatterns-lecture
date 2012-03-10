using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    abstract class CiaAerea
    {
        protected Reserva reserva;

        public Reserva ObterReserva()
        {
            return this.reserva;
        }

        public abstract void CriarPassageiro(string nome);
        public abstract void CriarTrecho(string origem, string destino, DateTime data);
        public abstract void CriarPagamento(string tipoPagamento);
    }

    abstract class Reserva { }

    class ViniciusAirLines : CiaAerea
    {
        public ViniciusAirLines()
        {
            this.reserva = new ReservaViniciusAirLines();
        }
        public override void CriarPassageiro(string nome)
        {
            //criar um passageiro nesta cia
        }

        public override void CriarTrecho(string origem, string destino, DateTime data)
        {
            //criar um trecho de vôo nesta cia
        }

        public override void CriarPagamento(string tipoPagamento)
        {
            //cria um pagamento nesta cia
        }
    }

    class ReservaViniciusAirLines : Reserva { }
}
