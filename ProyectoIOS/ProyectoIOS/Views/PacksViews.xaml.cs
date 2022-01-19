using Newtonsoft.Json;
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
    public partial class PacksViews : ContentPage
    {

        private const string Direccion = "http://www.webservicio.somee.com/";

        Pack d = new Pack();
        public PacksViews()
        {
            InitializeComponent();

            d = new Pack();

            BindingContext = d;

             
           
        }

        public async Task<Pack> BuscarPack(int pack)

        {

            Pack doc = null;

            

            String peticion = Direccion + "api/pack/" + pack;

            var uri = new Uri(string.Format(peticion, string.Empty));

            HttpClient client = CrearCliente();

            var respuesta = await client.GetAsync(uri);

            if (respuesta.IsSuccessStatusCode)

            {

                var contenido = await respuesta.Content.ReadAsStringAsync();

                doc = JsonConvert.DeserializeObject<Pack>(contenido);

                lblDescripcion.Text = doc.Descripcion;
                imgImagen.Source = doc.Imagen;
               

            }

            
            return doc;

        }

        private HttpClient CrearCliente()
        {

            HttpClient clientehttp = new HttpClient();

            clientehttp.DefaultRequestHeaders.Accept.Clear();

            clientehttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return clientehttp;

        }
    }
}