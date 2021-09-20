using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Modul5HW1.Models;
using Modul5HW1.Models.Items;
using Newtonsoft.Json;

namespace Modul5HW1.Services
{
    public class UsersClientService
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
