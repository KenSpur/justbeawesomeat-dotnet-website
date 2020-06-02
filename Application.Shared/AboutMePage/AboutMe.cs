using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Application.Shared.AboutMePage
{
    public class AboutMe
    {
        [JsonPropertyName("keywords")]
        public string Keywords { get; set; }
        [JsonPropertyName("Image_source")]
        public string ImageSource { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("future_ambitions")]
        public string FutureAmbitions { get; set; }

        [JsonPropertyName("info")]
        public Info Info { get; set; } = new Info();
        [JsonPropertyName("social_links")]
        public ICollection<SocialLink> SocialLinks { get; set; } = new List<SocialLink>();
        [JsonPropertyName("services")]
        public ICollection<Service> Services { get; set; } = new List<Service>();
        [JsonPropertyName("fun_facts")]
        public ICollection<FunFact> FunFacts { get; set; } = new List<FunFact>();
    }
}