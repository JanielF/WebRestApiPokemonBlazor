using BlazorDex.Models;
using System.Text.Json;

namespace BlazorDex.Util
{
    public class PokeClient
    {
        public  HttpClient client { get; set; }

        public PokeClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<Pokemons> GetPokemons (string id)
        {
            var response = await client.GetAsync ($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync ();

            return JsonSerializer.Deserialize<Pokemons>(content);
        }
    }
}
