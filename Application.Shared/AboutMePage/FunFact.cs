using System.Text.Json.Serialization;

namespace Application.Shared.AboutMePage
{
    public class FunFact
    {
        [JsonPropertyName("icon_class")]
        public string IconClass { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}