using System.Text.Json;

namespace BlazorBffDemo.BlazorClient.Client.Services
{
    public class FlexItApiService
    {
        private HttpClient _httpClient;

        public FlexItApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("api");
        }

        public async Task CallApiAsync()
        {
            var request = await _httpClient.GetAsync("identity");

            if (request.IsSuccessStatusCode)
            {
                var resultAsString = await request.Content.ReadAsStringAsync();
            }
        }

        //private async Task<T> FromHttpResponseMessageAsync<T>(HttpResponseMessage result)
        //{
        //    var data = JsonSerializer.Deserialize<T>(await result.Content.ReadAsStringAsync(), _serializerOptions);

        //    if (data is null)
        //    {
        //        throw new ArgumentException("Response body could not be deserializec.", nameof(result));
        //    }

        //    return data;
        //}
    }
}
