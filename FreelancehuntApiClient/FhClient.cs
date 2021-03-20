using System;
using System.Linq;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FreelancehuntApiClient
{
    public class FhClient : IDisposable
    {
        private const string BaseUrl = "https://api.freelancehunt.com/v2/";
        private readonly HttpClient client = new HttpClient();
        private readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy { ProcessDictionaryKeys = true }
            }
        };
        private Language language = Language.En;

        public Language Language
        {
            get => language;

            set
            {
                language = value;

                if (client.DefaultRequestHeaders.Contains("Accept-Language"))
                    client.DefaultRequestHeaders.Remove("Accept-Language");

                client.DefaultRequestHeaders.Add("Accept-Language", value.ToAcceptLanguageValue());
            }
        }

        public FhClient(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentException("Token is null or white space", nameof(token));

            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }

        public void Dispose()
        {
            client.Dispose();
        }

        /// <summary>
        /// Возвращает фид пользователя
        /// </summary>
        /// <returns></returns>
        public async Task<FhFeedObject[]> GetFeed()
        {
            var response        = await client.GetAsync("my/feed");
            var responseContent = await response.Content.ReadAsStringAsync();
            var fhResponse      = JsonConvert.DeserializeObject<FhResponse>(responseContent, jsonSerializerSettings);
            fhResponse.Message  = response;

            if (fhResponse.Error != null)
                throw new FhRequestException(fhResponse.Error);

            var feeds = fhResponse.Data
                .Select(dataObject =>
                {
                    var feed                = dataObject.Attributes.ToObject<FhFeedObject>(JsonSerializer.CreateDefault(jsonSerializerSettings));
                    feed.OwnerDataObject    = dataObject;

                    return feed;
                });

            return feeds.ToArray();
        }

        /// <summary>
        /// Пометить фид как прочитанный
        /// </summary>
        /// <returns></returns>
        public async Task MarkFeedAsRead()
        {
            var response        = await client.PostAsync("my/feed/read", null);
            var responseContent = await response.Content.ReadAsStringAsync();
            var fhResponse      = JsonConvert.DeserializeObject<FhResponse>(responseContent, jsonSerializerSettings);

            if (fhResponse is null)
                fhResponse = new FhResponse() { Message = response };
            
            if (fhResponse.Error != null)
                throw new FhRequestException(fhResponse.Error);
        }
    }
}
