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
    public partial class RegistrarRestaurante : ContentPage
    {
        public RegistrarRestaurante()
        {
            InitializeComponent();

            this.btnIngresar.Clicked += BtnIngresar_Clicked;

       
        }

        async void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            HelperRegistro helperRegistro =  new  HelperRegistro();

            Restaurante restaurante = new Restaurante
            {
                Nombre = txtNombre.Text.ToString(),
                NombreCalle = txtNombrCalle.Text,
                NumeroCalle = txtNumeroCalle.Text,
                Horario = txtHorario.Text.ToString(),
                Telefono = txtTelefono.Text,
                Descripcion = txtDescripcion.Text,
                Imagen = txtImagen.Text
            };

          await  helperRegistro.InsertarRestaurante(restaurante);

            await DisplayAlert("Alerta", "Datos Ingresados correctamente", "Ok");

        }
    }
}