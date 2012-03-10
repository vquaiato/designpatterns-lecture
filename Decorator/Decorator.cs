using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public interface ITexto
    {
        string Exibir();
    }

    public class TextoPlano : ITexto
    {
        private string text;

        public TextoPlano(string text)
        {
            this.text = text;
        }

        public string Exibir()
        {
            return this.text;
        }
    }


    public class Sublinhado : ITexto
    {
        private ITexto text;

        public Sublinhado(ITexto text)
        {
            this.text = text;
        }

        public string Exibir()
        {
            return "<u>" + this.text.Exibir() + "</u>";
        }
    }


    public class Italico : ITexto
    {
        private ITexto text;

        public Italico(ITexto text)
        {
            this.text = text;
        }

        public string Exibir()
        {
            return "<i>" + this.text.Exibir() + "</i>";
        }
    }
    public class Negrito : ITexto
    {
        private ITexto texto;

        public Negrito(ITexto texto)
        {
            this.texto = texto;
        }

        public string Exibir()
        {
            return "<b>" + this.texto.Exibir() + "</b>";
        }
    }
}
