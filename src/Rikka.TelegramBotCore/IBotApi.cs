using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TelegramBotCore
{
    public interface IBotApi
    {
        Task<string> BotMethod<TSend>(string method, TSend data);
        Task<TResult> BotMethod<TSend, TResult>(string method, TSend data) where TResult : class;
        Task<byte[]> GetFile(string filePath);
    }

    public class BotApi : IBotApi
    {
        private readonly HttpClient _client;
        private readonly string _token;

        public BotApi(string token)
        {
            _token = token;
        }

        public string Method(string method)
        {
            return $"https://api.telegram.org/bot{_token}/{method}";
        }


        public async Task<string> BotMethod<TSend>(string method, TSend data)
        {
            var result = await _makreRequest<TSend>(Method(method), data);
            return result;
        }

        public async Task<TResult> BotMethod<TSend, TResult>(string method, TSend data) where TResult : class
        {
            var result = await _makreRequest<TSend, TResult>(Method(method), data);
            return result;
        }

        public async Task<byte[]> GetFile(string filePath)
        {
            var result = await _client.GetAsync($"https://api.telegram.org/file/bot{_token}/{filePath}");
            return await result.Content.ReadAsByteArrayAsync();
        }
        private async Task<string> _makreRequest(string url)
        {
            var result = await _client.GetAsync(url);
            return await result.Content.ReadAsStringAsync();
        }
        private async Task<string> _makreRequest<TSend>(string url, TSend data)
        {
            try
            {
                var json = JsonConvert.SerializeObject(data, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                var buffer = Encoding.UTF8.GetBytes(json);
                var client = new HttpClient();

                var request = new HttpRequestMessage(HttpMethod.Post, url) {Content = new StringContent(json,Encoding.UTF8, "application/json") };
                var response = await client.SendAsync(request);
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        private async Task<TResponse> _makreRequest<TSend, TResponse>(string url, TSend data) where TResponse : class
        {
            var json = await _makreRequest<TSend>(url, data);
            TResponse result = null;
            try
            {
                result = JsonConvert.DeserializeObject<TResponse>(json);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }        
    }
}
