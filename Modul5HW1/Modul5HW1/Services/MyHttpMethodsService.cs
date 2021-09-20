using System;
using System.Net.Http;
using System.Threading.Tasks;
using Modul5HW1.Services.Abstractions;
using Newtonsoft.Json;

namespace Modul5HW1.Services
{
    public class MyHttpMethodsService : IMyHttpMethodsService
    {
        private HttpClient _client = new HttpClient();

        public async Task<T> MyGetAsync<T>(string url)
        {
            var method = HttpMethod.Get;
            var uri = new Uri(url);
            var data = await GetDataAsync(method, uri);
            var result = JsonConvert.DeserializeObject<T>(data);

            return result;
        }

        public async Task<T> MyPostAsync<T>(string url, string content)
        {
            var method = HttpMethod.Post;
            var uri = new Uri(url);
            var data = await GetDataAsync(method, uri, content);
            var result = JsonConvert.DeserializeObject<T>(data);

            return result;
        }

        public async Task<T> MyPutAsync<T>(string url, string content)
        {
            var method = HttpMethod.Put;
            var uri = new Uri(url);
            var data = await GetDataAsync(method, uri, content);
            var result = JsonConvert.DeserializeObject<T>(data);

            return result;
        }

        public async Task<T> MyPathAsync<T>(string url, string content)
        {
            var method = HttpMethod.Patch;
            var uri = new Uri(url);
            var data = await GetDataAsync(method, uri, content);
            var result = JsonConvert.DeserializeObject<T>(data);

            return result;
        }

        public async Task DeleteAsync(int id)
        {
            var method = HttpMethod.Delete;
            var uri = new Uri($"https://reqres.in/api/users/{id}");
            await GetDataAsync(method, uri);
        }

        private async Task<string> GetDataAsync(HttpMethod httpMethod, Uri uriString, string content = null)
        {
            var message = new HttpRequestMessage();

            message.Method = httpMethod;
            message.RequestUri = uriString;

            if (!string.IsNullOrEmpty(content))
            {
                message.Content = new StringContent(content);
            }

            var response = await _client.SendAsync(message);

            var data = await response.Content.ReadAsStringAsync();

            return data;
        }
    }
}
