using System.Text.Json.Serialization;

namespace Application.Shared.ResumePage
{
    public class Certification
    {
        [JsonPropertyName("period")]
        public string Period { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("authority")]
        public string Authority { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}