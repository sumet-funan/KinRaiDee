using System.Text.Json.Serialization;

namespace KinRaiDee.Web.Models
{
    public class Cooking
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("raw_material")]
        public RawMaterial[] RawMaterial { get; set; }

        [JsonPropertyName("cooking_method")]
        public CookingMethod[] CookingMethod { get; set; }
    }
}
