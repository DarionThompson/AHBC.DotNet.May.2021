using IntroToApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace IntroToApis.Services
{
    public class ToolsClient
    {
        private readonly HttpClient _httpClient;

        private readonly JsonSerializerOptions _options;
        public ToolsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<List<ToolsResponseModel>> GetToolsAsync()
        {
            //Use the http client to get the response;
            var response = await _httpClient.GetAsync("https://localhost:5001/api/tools/thing1");
            //or if its a simple get request
            //Sends request, get request and format in one step
            //var response = await _httpClient.GetStringAsync("people");

            //grab the json from the response content
            var jsonResponse = await response.Content.ReadAsStringAsync();

            //deserialize our json and converting it to our model
            var toolsResponseModel = JsonSerializer.Deserialize<List<ToolsResponseModel>>(jsonResponse, _options);

            return toolsResponseModel;
        }

        public async Task<List<ToolsResponseModel>> GetSingleTool()
        {
            //Use the http client to get the response;
            var response = await _httpClient.GetAsync("https://localhost:5001/api/tools/thing1/tool1");
            //or if its a simple get request
            //Sends request, get request and format in one step
            //var response = await _httpClient.GetStringAsync("people");

            //grab the json from the response content
            var jsonResponse = await response.Content.ReadAsStringAsync();

            //deserialize our json and converting it to our model
            var toolsResponseModel = JsonSerializer.Deserialize<List<ToolsResponseModel>>(jsonResponse, _options);

            return toolsResponseModel;
        }
    }
}
