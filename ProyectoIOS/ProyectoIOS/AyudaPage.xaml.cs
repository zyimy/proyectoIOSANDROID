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
    public partial class AyudaPage : ContentPage
    {
        FireBaseHelper firebaseHelper = new FireBaseHelper();
        public AyudaPage()
        {
            InitializeComponent();

        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allAyuda = await firebaseHelper.GetAllComentario();
            lstAyuda.ItemsSource = allAyuda;
        }

        private async void agregarAyuda_Clicked(object sender, EventArgs e)
        {
            await firebaseHelper.AddAyuda(txtNombre.Text, txtApellido.Text, comen.Text);
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            comen.Text = string.Empty;
           

            await DisplayAlert("Success", "Help Successfully", "OK");
            var allPersons = await firebaseHelper.GetAllComentario();
            lstAyuda.ItemsSource = allPersons;
        }

        private void app_OnChanged(object sender, ToggledEventArgs e)
        {
            app.OnChanged += app_OnChanged;
        }
    }
}