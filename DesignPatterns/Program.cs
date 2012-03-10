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
            FabricaProdutosAbstrata fabricaWeb = new FabricaProdutosWeb();
            FabricaProdutosAbstrata fabricaLoja = new FabricaProdutosLoja();

            ProdutoAbstrato produto = fabricaWeb.CriarProdutoEstoque();
            //PromocaoAbstrata promocao = fabricaLoja.CriarPromocao();
            ProdutoAbstrato produto2 = fabricaLoja.CriarProdutoEstoque();

            VenderProduto(produto);
            VenderProduto(produto2);
        }

        static void VenderProduto(ProdutoAbstrato produtoASerVendido)
        {
            produtoASerVendido.Vender();
        }
    }
}
