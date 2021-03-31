using API_Practice.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace API_Practice.Services
{
    public class JokeAPIClient
    {
        private readonly HttpClient _client;

        public JokeAPIClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<RandomJokeResponse> GetRandomJoke()
        {
            return await GetAsync<RandomJokeResponse>("jokes/random");
        }
        public async Task<TenRandomJokesResponse> GetTenRandomJokes()
        {
            return await GetAsync<TenRandomJokesResponse>("jokes/ten");
        }
        private async Task<T> GetAsync<T>(string endPoint)
        {
            var response = await _client.GetAsync(endPoint);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStreamAsync();
                var model = await JsonSerializer.DeserializeAsync<T>(content);

                return model;
            }
            else
            {
                throw new HttpRequestException("Joke API has a bad respose.");
            }
        }
    }
}
