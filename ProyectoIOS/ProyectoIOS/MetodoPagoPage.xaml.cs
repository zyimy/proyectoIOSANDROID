using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIOS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MetodoPagoPage : ContentPage
    {
        public MetodoPagoPage()
        {
            InitializeComponent();
            this.BindingContext = new MetodoPagoPageViewModel();
        }

        private async void tarjeta_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("EXITO", "Operacion Exitosa", "OK");
           
        }
    }
}