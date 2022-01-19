using Newtonsoft.Json;
using ProyectoIOS.Helpers;
using ProyectoIOS.Models;

using ProyectoIOS.ViewModels;
using ProyectoIOS.Views;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIOS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class prueba : ContentPage
    {
       

        HelperPack pack = new HelperPack();
        public prueba()
        {
            InitializeComponent();
            
            
        }

        async void listaRest_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            PacksViews packModel = new PacksViews();
            if (e.Item == null)
            {
                return;
            }

            ((ListView)sender).SelectedItem = null;
            await packModel.BuscarPack(e.ItemIndex +1);
            await Navigation.PushAsync(packModel);

        }

       
    }
}