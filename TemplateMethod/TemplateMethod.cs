using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    abstract class Pagamento
    {
        public void CalcularTotal()
        {
            SomarTotalItens();

            SomarJuros();

            SomarTaxasExtras();
        }

        public virtual void SomarJuros(){}
        public virtual void SomarTaxasExtras(){}

        private void SomarTotalItens()
        {
            //iterar os itens e somar
        }
    }

    class PagamentoAVista : Pagamento
    {
    }
    class PagamentoParcelado : Pagamento
    {
        public override void SomarJuros()
        {
            //soma taxas de juros variando número de parcelas
        }

        public override void SomarTaxasExtras()
        {
            //soma alguma taxa de parcelamento
        }
    }
}
