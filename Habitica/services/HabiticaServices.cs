using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Habitica.interfaces;

namespace Habitica.services
{
    public class HabiticaServices
    {

        private readonly HttpClient client = new();
        private readonly JsonSerializerOptions _jsonOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };


        public HabiticaServices()
        {
            client.DefaultRequestHeaders.Add("x-client", "c150cf43-bf4a-4c46-8912-9c04f77d3924-cordeiroAPI");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("x-api-key", "3a00e702-525c-41f2-a69a-d10b741b0c5c");
            client.DefaultRequestHeaders.Add("x-api-user", "c150cf43-bf4a-4c46-8912-9c04f77d3924");

            client.BaseAddress = new Uri("https://habitica.com");

        }

        public async Task<List<HabiticaDatum>?> GetTasks()
        {
            using var message = new HttpRequestMessage(HttpMethod.Get, "/api/v3/tasks/user?type=todos");
            var response = await client.SendAsync(message).Result.Content.ReadFromJsonAsync<HabiticaResponse>(_jsonOptions);

            return response?.Data;

        }
        public async Task<List<HabiticaNotification>?> GetNotifications()
        {
            using var message = new HttpRequestMessage(HttpMethod.Get, "/api/v3/tasks/user?type=todos");
            var response = await client.SendAsync(message).Result.Content.ReadFromJsonAsync<HabiticaResponse>(_jsonOptions);

            return response?.Notifications;

        }
    }
}
