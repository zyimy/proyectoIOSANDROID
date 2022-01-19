using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace ProyectoIOS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mas : ContentPage
    {
        public Mas()
        {
            Xamarin.Forms.NavigationPage.SetHasBackButton(this, false);
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            InitializeComponent();
        }

        private  async void botonblog_Clicked(object sender, EventArgs e)
        {
            BlogPage blogView = new BlogPage();
            await Navigation.PushAsync(blogView);
        }

        private  async void botonayuda_Clicked(object sender, EventArgs e)
        {
            AyudaPage ayudaView = new AyudaPage();
            await Navigation.PushAsync(ayudaView);
        }

        private async void terminos_Clicked(object sender, EventArgs e)
        {
            Terminos terminos = new Terminos();
            await Navigation.PushAsync(terminos);
        }

        private  async void pagos_Clicked(object sender, EventArgs e)
        {
            MetodoPagoPage metodoPagoPage = new MetodoPagoPage();
            await Navigation.PushAsync(metodoPagoPage);
        }
    }
}