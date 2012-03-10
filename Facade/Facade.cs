using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    class Facade
    {
        private WebServiceVendas vendas;
        private WebServiceCartaoCreditoA cartaoA;
        private WebServiceCartaoCreditoN cartaoN;
        private ServicoDeLog log;

        public Facade()
        {
            this.vendas = new WebServiceVendas();
            this.cartaoA = new WebServiceCartaoCreditoA();
            this.cartaoN = new WebServiceCartaoCreditoN();
            this.log = new ServicoDeLog();
        }

        public void IniciarComunicacoes()
        {
            this.vendas.IniciarServicoDeVendas("loja XPTO");
            this.cartaoA.Autenticar("loja", "123");
            this.cartaoN.OpenConnection("XASP234U@#$$42");
            this.log.StartLogInConsole("login", "senha");
        }
    }

    class WebServiceVendas
    {
        public void IniciarServicoDeVendas(string nomeLoja)
        {
            //inicia um serviço
        }
    }
    class WebServiceCartaoCreditoA
    {
        public void Autenticar(string loja, string codigoAcesso)
        {
            //inicia comunicação com serviço externo
        }
    }
    class WebServiceCartaoCreditoN
    {
        public void OpenConnection(string shopCode)
        {
            //inicia comunicação com empresa de certão
        }
    }
    class ServicoDeLog
    {
        public void StartLogInConsole(string domainUser, string password)
        {
            //inicia um processo de log no console 
        }
    }
}
