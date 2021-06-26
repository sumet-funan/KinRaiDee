using System.Text.Json.Serialization;

namespace KinRaiDee.Web.Models
{
    public class RawMaterial
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("volumn")]
        public long Volumn { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
