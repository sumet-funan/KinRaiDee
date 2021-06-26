using System.Text.Json.Serialization;

namespace KinRaiDee.Web.Models
{
    public class CookingMethod
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("desciption")]
        public string Desciption { get; set; }
    }
}
