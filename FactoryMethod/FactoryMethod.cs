using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    abstract class ImagemRelatorio {
		public abstract void Render();
	}

    class JpegRelatorio : ImagemRelatorio {
		public override void Render ()
		{
			Console.WriteLine("Imagem JPEG");
		}
	}
    class GifRelatorio : ImagemRelatorio {
		public override void Render ()
		{
			Console.WriteLine("Imagem GIF");
		}
	}
    class BitmapRelatorio : ImagemRelatorio { 
		public override void Render ()
		{
			Console.WriteLine("Imagem BITMAP");
		}
	}

    abstract class Relatorio
    {
        public abstract ImagemRelatorio GerarImagem();
    }

    class RelatorioJpeg : Relatorio
    {
        public override ImagemRelatorio GerarImagem()
        {
            return new JpegRelatorio();
        }
    }
    class RelatorioGif : Relatorio
    {
        public override ImagemRelatorio GerarImagem()
        {
            return new GifRelatorio();
        }
    }
}
