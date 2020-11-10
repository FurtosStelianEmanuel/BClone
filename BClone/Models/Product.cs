using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BClone.Models
{
    public class Product
    {
        [JsonPropertyName("nume")]
        public String Nume { get; set; }
        [JsonPropertyName("imagineDefault")]
        public String ImagineDefault { get; set; }
        [JsonPropertyName("descriere")]
        public String Descriere { get; set; }
        [JsonPropertyName("pret")]
        public decimal Pret { get; set; }

    }
}
