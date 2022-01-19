using ProyectoIOS.Helpers;
using ProyectoIOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIOS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarPack : ContentPage
    {
        public RegistrarPack()
        {
            InitializeComponent();

            this.btnIngresar.Clicked += BtnIngresar_Clicked;
        }

        async void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            HelperRegistro helperRegistro = new HelperRegistro();
            Pack pack = new Pack
            {
                Descripcion = txtDescripcion.Text,
                Precio = txtPrecio.Text,
                Imagen = txtImagen.Text
             


            };

            await helperRegistro.InsertarPack(pack);

            await DisplayAlert("Alerta", "Datos Ingresados correctamente", "Ok");
        }
    }
}