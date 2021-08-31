using IntroToApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace IntroToApis.Services
{
    public class StarWarsClient : IStarWarsClient
    {
        private readonly HttpClient _httpClient;
        public StarWarsClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<StarWarsPeopleResponse> GetPeopleAsync()
        {
            //Use the http client to get the response;
            var response = await _httpClient.GetAsync("people");
            //or if its a simple get request
            //Sends request, get request and format in one step
            //var response = await _httpClient.GetStringAsync("people");

            //grab the json from the response content
            var jsonResponse = await response.Content.ReadAsStringAsync();

            //deserialize our json and converting it to our model
            var peopleResponse = JsonSerializer.Deserialize<StarWarsPeopleResponse>(jsonResponse);

            return peopleResponse;
        }
    }
}
