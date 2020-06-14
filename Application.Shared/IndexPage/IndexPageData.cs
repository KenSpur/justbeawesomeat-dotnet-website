using System.Text.Json.Serialization;

namespace Application.Shared.IndexPage
{
    public class IndexPageData : IPageData
    {
        [JsonPropertyName("title")]
        public Title Title { get; set; } = new Title();
    }
}