using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    abstract class FabricaProdutosAbstrata
    {
        public abstract ProdutoAbstrato CriarProdutoEstoque();
        public abstract PromocaoAbstrata CriarPromocao();
    }

    class FabricaProdutosWeb : FabricaProdutosAbstrata
    {
        public override ProdutoAbstrato CriarProdutoEstoque()
        {
            //cria um produto para Web

            return new ProdutoWeb();
        }

        public override PromocaoAbstrata CriarPromocao()
        {
            //cria uma promoção para web

            return new PromocaoWeb();
        }
    }
    class FabricaProdutosLoja : FabricaProdutosAbstrata
    {
        public override ProdutoAbstrato CriarProdutoEstoque()
        {
            //cria um produto para Loja

            return new ProdutoLoja();
        }

        public override PromocaoAbstrata CriarPromocao()
        {
            //cria uma promoção para loja

            return new PromocaoLoja();
        }
    }

    abstract class ProdutoAbstrato {
		public abstract void Vender();
	}    
    abstract class PromocaoAbstrata { }

    class ProdutoWeb : ProdutoAbstrato {
		public override void Vender(){
			Console.WriteLine("vendendendo produto Web");
		}
	}
    class PromocaoWeb : PromocaoAbstrata { }

    class ProdutoLoja : ProdutoAbstrato {
		public override void Vender (){
			Console.WriteLine("vendendo produto loja");
		}
	}
    class PromocaoLoja : PromocaoAbstrata { }
}
