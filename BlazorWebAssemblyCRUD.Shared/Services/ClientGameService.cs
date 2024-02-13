using BlazorWebAssemblyCRUD.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorWebAssemblyCRUD.Shared.Services
{
    public class ClientGameService : IGameService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;

        public ClientGameService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _serializerOptions = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};
        }

        public async Task CreateGame(Game game)
        {
            try
            {
                var gameJson = new StringContent(JsonSerializer.Serialize(game), Encoding.UTF8, "application/json");
                var apiResponse = await _httpClient.PostAsync("api/Games", gameJson);
                

                //if (!apiResponse.IsSuccessStatusCode)
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<List<Game>> GetAll()
        {
            try
            {
                var apiResponse = await _httpClient.GetFromJsonAsync<List<Game>>("api/Games", _serializerOptions);

                return apiResponse ?? new List<Game>();
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
