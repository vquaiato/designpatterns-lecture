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
            Relatorio relatorioGif = new RelatorioGif();
            ImagemRelatorio imagem = relatorioGif.GerarImagem();
			RenderImage(imagem);

            //Relatorio relastorioJpeg = new RelatorioJpeg();
            ImagemRelatorio imagem2 = new RelatorioJpeg().GerarImagem();
			RenderImage(imagem2);
        }
		
		static void RenderImage(ImagemRelatorio imagem)
		{
			imagem.Render();
		}
    }
}
