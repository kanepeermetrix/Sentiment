using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using Newtonsoft.Json;
using Sentiment.Models;

namespace Sentiment.Clients
{
    public class SentimentService
    {
        private HttpClient _httpClient { get; set; }
        public SentimentService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://eastus.api.cognitive.microsoft.com");
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "aceb48dbf78243fb9800176b47b0d057");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient = httpClient;
        }

        public async Task<string> SendToAzure(DocumentList documentList)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/text/analytics/v2.1/sentiment")
            {
                Content = new StringContent(JsonConvert.SerializeObject(documentList), Encoding.UTF8, MediaTypeNames.Application.Json)
            };
            var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            return responseContent;
        }
    }

}