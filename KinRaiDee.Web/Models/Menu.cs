using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KinRaiDee.Web.Models
{
    public class Menu
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("meat")]
        public string Meat { get; set; }

        [JsonPropertyName("cookings")]
        public Cooking[] Cookings { get; set; }
    }
}
