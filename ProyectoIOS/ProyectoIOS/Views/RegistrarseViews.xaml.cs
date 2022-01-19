using Newtonsoft.Json;
using ProyectoIOS.Helpers;
using ProyectoIOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIOS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarseViews : ContentPage
    {
        private const string DireccionApi = "http://www.webservicio.somee.com/";
        public RegistrarseViews()
        {
            InitializeComponent();

            this.btnIngresar.Clicked += BtnIngresar_Clicked;

            
            
        }

        async void BtnIngresar_Clicked(object sender, EventArgs e)
        {

            HelperRegistro helperRegistro = new HelperRegistro();
            Registro registro = new Registro
            {
                Nombre = txtNombre.Text.ToString(),
                Apellido = txtApellido.Text.ToString(),
                CorreoElectronico = txtCorreo.Text,
                Contrasena = txtContrasena.Text,
                Telefono = txtTelefono.Text


            };

            await helperRegistro.InsertarRegistro(registro);

            MainPage main = new MainPage();

          await  DisplayAlert("Alerta", "Datos Ingresados correctamente", "Ok");

            

            await Navigation.PushAsync(main);

        }

      
    }
}