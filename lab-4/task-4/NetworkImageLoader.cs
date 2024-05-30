using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class NetworkImageLoader : IImageLoader
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public byte[] LoadImage(string url)
        {
            var task = Task.Run(async () =>
            {
                var response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsByteArrayAsync();
            });
            return task.Result;
        }
    }
}
