using System;
using System.Text.Json;
using System.Threading.Tasks;
using Application.Server.Options;
using Application.Shared;
using Application.Shared.AboutMePage;
using Application.Shared.ContactPage;
using Application.Shared.IndexPage;
using Application.Shared.MainPage;
using Application.Shared.ResumePage;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Options;

namespace Application.Server.Services.Implementations
{
    public class StorageService : IStorageService
    {
        private readonly AzureStorageOptions _options;

        public StorageService(IOptions<AzureStorageOptions> options)
        {
            _options = options.Value;
        }

        public async Task<T> GetDataAsync<T>() where T : IPageData
        {
            var container = new BlobContainerClient(_options.ConnectionString, _options.WebsiteDataContainer);
            var blob = container.GetBlobClient(GetBlobName<T>());

            var download = await blob.DownloadAsync();

            return await JsonSerializer.DeserializeAsync<T>(download.Value.Content);
        }

        private string GetBlobName<T>() where T : IPageData
        {
            if (typeof(T) == typeof(MainPageData)) return _options.MainBlob;
            if (typeof(T) == typeof(IndexPageData)) return _options.IndexBlob;
            if (typeof(T) == typeof(AboutMePageData)) return _options.AboutMeBlob;
            if (typeof(T) == typeof(ResumePageData)) return _options.ResumeBlob;
            if (typeof(T) == typeof(ContactPageData)) return _options.ContactBlob;
            
            throw new ArgumentOutOfRangeException();
        }
    }
}