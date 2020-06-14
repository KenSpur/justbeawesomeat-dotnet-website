namespace Application.Server.Options
{
    public class AzureStorageOptions
    {
        public string ConnectionString { get; set; }
        public string WebsiteDataContainer { get; set; }
        public string MainBlob { get; set; }
        public string IndexBlob { get; set; }
        public string AboutMeBlob { get; set; }
        public string ResumeBlob { get; set; }
        public string ContactBlob { get; set; }
    }
}