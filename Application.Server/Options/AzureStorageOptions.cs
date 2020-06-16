namespace Application.Server.Options
{
    public class AzureStorageOptions
    {
        public string ConnectionString { get; set; }
        public string WebsitePageDataContainer { get; set; }
        public string MainPageDataBlob { get; set; }
        public string IndexPageDataBlob { get; set; }
        public string AboutMePageDataBlob { get; set; }
        public string ResumePageDataBlob { get; set; }
        public string ContactPageDataBlob { get; set; }
    }
}