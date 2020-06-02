using System.Text.Json.Serialization;

namespace Application.Shared.ResumePage
{
    public class Skill
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("percentage")]
        public int Percentage { get; set; }
    }
}