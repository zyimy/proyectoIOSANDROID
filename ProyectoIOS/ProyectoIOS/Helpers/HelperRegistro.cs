using Newtonsoft.Json;
using ProyectoIOS.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIOS.Helpers
{
    public class HelperRegistro
    {
        private const string DireccionApi = "http://www.webservicio.somee.com/";

        private HttpClient CrearCliente()

        {

            HttpClient clientehttp = new HttpClient();

           clientehttp.DefaultRequestHeaders.Accept.Clear();

            clientehttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return clientehttp;

        }

        public async Task<List<Restaurante>> GetRestaurantes()

        {

            List<Restaurante> listadatos = null;

            String peticion = DireccionApi + "api/restaurante";

            var uri = new Uri(string.Format(peticion, string.Empty));

           HttpClient client = CrearCliente();

            var respuesta = await client.GetAsync(uri);

            if (respuesta.IsSuccessStatusCode)

            {

                var contenido = await respuesta.Content.ReadAsStringAsync();

                listadatos = JsonConvert.DeserializeObject<List<Restaurante>>(contenido);

            }

            return listadatos;

        }

        public async Task<bool> InsertarRestaurante(Restaurante restaurante)

        {

            //CONVERTIMOS EL OBJETO EN JSON 

            string jsondoctor = JsonConvert.SerializeObject(restaurante, Formatting.Indented);

            //PASAMOS SUS DATOS A BYTES 

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(jsondoctor);

            //CREAMOS UN CONTENIDO DE BYTES PARA ENVIAR 

            //EN LA PETICION 

            ByteArrayContent content = new ByteArrayContent(buffer);

            //INDICAMOS EN LA CABECERA EL TIPO DE CONTENIDO A ENVIAR 

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //CREAMOS EL CLIENTE 

            HttpClient client = CrearCliente();

            //CREAMOS LA PETICION 

            String peticion = DireccionApi + "api/restaurante";

            //REALIZAMOS LA LLAMADA AL API POST ENVIANDO EL CONTENIDO 

            var respuesta = await client.PostAsync(peticion, content);

            if (respuesta.IsSuccessStatusCode)

            {

                return true;


            }

            else

            {

                return false;

            }

        }

        public async Task<bool> InsertarRegistro(Registro registro)

        {

            //CONVERTIMOS EL OBJETO EN JSON 

            string jsondoctor = JsonConvert.SerializeObject(registro, Formatting.Indented);

            //PASAMOS SUS DATOS A BYTES 

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(jsondoctor);

            //CREAMOS UN CONTENIDO DE BYTES PARA ENVIAR             

            //EN LA PETICION 

            ByteArrayContent content = new ByteArrayContent(buffer);

            //INDICAMOS EN LA CABECERA EL TIPO DE CONTENIDO A ENVIAR 

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //CREAMOS EL CLIENTE 

            HttpClient client = CrearCliente();

            //CREAMOS LA PETICION 

            String peticion = DireccionApi + "api/registro";

            //REALIZAMOS LA LLAMADA AL API POST ENVIANDO EL CONTENIDO 

            var respuesta = await client.PostAsync(peticion, content);

            if (respuesta.IsSuccessStatusCode)

            {

                return true;


            }

            else

            {

                return false;

            }

        }

        public async Task<bool> InsertarPack(Pack pack)

        {

            //CONVERTIMOS EL OBJETO EN JSON 

            string jsondoctor = JsonConvert.SerializeObject(pack, Formatting.Indented);

            //PASAMOS SUS DATOS A BYTES 

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(jsondoctor);

            //CREAMOS UN CONTENIDO DE BYTES PARA ENVIAR             

            //EN LA PETICION 

            ByteArrayContent content = new ByteArrayContent(buffer);

            //INDICAMOS EN LA CABECERA EL TIPO DE CONTENIDO A ENVIAR 

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            //CREAMOS EL CLIENTE 

            HttpClient client = CrearCliente();

            //CREAMOS LA PETICION 

            String peticion = DireccionApi + "api/pack";

            //REALIZAMOS LA LLAMADA AL API POST ENVIANDO EL CONTENIDO 

            var respuesta = await client.PostAsync(peticion, content);

            if (respuesta.IsSuccessStatusCode)

            {

                return true;


            }

            else

            {

                return false;

            }

        }


    }
}
