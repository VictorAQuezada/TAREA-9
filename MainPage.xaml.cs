using System;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace MisLenguajesFavoritos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ir_html_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/HTML", BrowserLaunchMode.SystemPreferred);
        }

        private void Ir_css_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://es.wikipedia.org/wiki/Hoja_de_estilos_en_cascada", BrowserLaunchMode.SystemPreferred);
        }

        // Agrega más métodos para los otros botones siguiendo el mismo patrón
    }
}
