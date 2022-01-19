using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIOS.Models
{
    public class Pack
    {
        [JsonProperty("idPack")]
        public int IdPack { get; set; }
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
        [JsonProperty("imagen")]
        public string Imagen { get; set; }

        [JsonProperty("precio")]
        public string Precio { get; set; }
    }
}
