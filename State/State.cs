using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class Compra
    {
        public StatusDaCompra Status { get; internal set; }
        public List<ItemCompra> Itens { get; set; }

        public Compra()
        {
            this.Status = new AguardandoConfirmacaoPagamento();
        }

        public string ObterInformacoesDaCompra()
        {
            return Status.Informacao(this);
        }
        public void MudarStatus()
        {
            this.Status.ProximoStatus(this);
        }
    }
    public class ItemCompra { }

    public abstract class StatusDaCompra
    {
        public abstract string Informacao(Compra compra);
        public abstract void ProximoStatus(Compra compra);
    }

    public class AguardandoConfirmacaoPagamento : StatusDaCompra
    {
        public override string Informacao(Compra compra)
        {
            return "Estamos aguarando a confirmacao de pagamento da instituição financeira";
        }

        public override void ProximoStatus(Compra compra)
        {
            compra.Status = new Enviada();
        }
    }
    public class Enviada : StatusDaCompra
    {
        public override string Informacao(Compra compra)
        {
            return "O pagamento da compra já foi confirmado, e a mesma foi enviada para o endereço de entrega na data X";
        }

        public override void ProximoStatus(Compra compra)
        {
            compra.Status = new Entregue();
        }
    }
    public class Entregue : StatusDaCompra
    {
        public override string Informacao(Compra compra)
        {
            return "Sua compra foi enviada e entregue no endereço informado.";
        }

        public override void ProximoStatus(Compra compra)
        {
			//fim da linha
        }
    }
}
