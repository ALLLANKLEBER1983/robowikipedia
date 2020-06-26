using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRoboWiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePesquisa : ContentPage
    {
        public PagePesquisa()
        {
            InitializeComponent();
        }

        public PagePesquisa(ClassWikiPedia dados)
        {
            InitializeComponent();
            lTitulo.Text = dados.title;
            GetImages(dados);
            eDados.Text = dados.content;
        }

        public void GetImages(ClassWikiPedia dados)
        {
            String imagem = "";
            int i = 0;
            while (i < dados.images.Length)
            {
                if (dados.images[i].IndexOf("jpg")>0)
                {
                    imagem = dados.images[i];
                    Image image = new Image { Source = imagem, HeightRequest = 300 };
                    sImagens.Children.Add(image);

                }
                i++;
            }
        }
    }
}