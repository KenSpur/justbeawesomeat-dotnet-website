using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Application.Shared.ResumePage
{
    public class Skills
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("collection")]
        public ICollection<Skill> Collection { get; set; } = new List<Skill>();
    }
}