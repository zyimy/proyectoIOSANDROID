using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIOS.Models
{
   public class Restaurante
    {
        [JsonProperty("idRestaurante")]
        public int IdRestaurante { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("telefono")]
        public string Telefono { get; set; }
        [JsonProperty("horario")]
        public string Horario { get; set; }
        [JsonProperty("nombreCalle")]
        public string NombreCalle { get; set; }
        [JsonProperty("numeroCalle")]
        public string NumeroCalle { get; set; }
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
        [JsonProperty("imagen")]
        public string Imagen { get; set; }
    
    }
}
