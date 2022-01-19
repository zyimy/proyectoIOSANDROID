using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
namespace ProyectoIOS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favoritos : ContentPage
    {
        public Favoritos()
        {
            Xamarin.Forms.NavigationPage.SetHasBackButton(this, false);
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
            InitializeComponent();
        }
    }
}