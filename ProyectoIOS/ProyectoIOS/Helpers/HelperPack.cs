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
    public class HelperPack
    {
        private const string Direccion = "http://www.webservicio.somee.com/";

        private HttpClient CrearCliente()
{

          HttpClient clientehttp = new HttpClient();

           clientehttp.DefaultRequestHeaders.Accept.Clear();

            clientehttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return clientehttp;

        }

        //public async Task<List<Pack>> GetPacks()

        //{

        //   List<Pack> listadatos = null;

        //   String peticion = Direccion + "api/pack";

        //   var uri = new Uri(string.Format(peticion, string.Empty));

        //   HttpClient client = CrearCliente();

        //    var respuesta = await client.GetAsync(uri);

        //    if (respuesta.IsSuccessStatusCode)

        //    {

        //       var contenido = await respuesta.Content.ReadAsStringAsync();

        //        listadatos = JsonConvert.DeserializeObject<List<Pack>>(contenido);

        //   }

        //    return listadatos;

        //}

        //public async Task<Pack> BuscarPack(int pack)

        //{

        //    Pack doc = null;

        //    //CREAMOS LA PETICION 

        //    String peticion = Direccion + "api/pack/" + pack;

        //    var uri = new Uri(string.Format(peticion, string.Empty));

        //    HttpClient client = CrearCliente();

        //    var respuesta = await client.GetAsync(uri);

        //    if (respuesta.IsSuccessStatusCode)

        //    {

        //        var contenido = await respuesta.Content.ReadAsStringAsync();

        //        doc = JsonConvert.DeserializeObject<Pack>(contenido);

        //    }

        //    return doc;

        //}

    }
}
