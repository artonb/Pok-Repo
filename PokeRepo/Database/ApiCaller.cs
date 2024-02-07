using Newtonsoft.Json;
using PokeRepo.Models;

namespace PokeRepo.Database
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }

        public ApiCaller()
        {
            Client = new();
            //Lägg till en basadress till klienten, eftersom att alla calls kommer gå till den sidan.
            //Nu kan jag skriva gör ett call till Users så tar den basadressen + /Users
            Client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
        }

        public async Task<Root> MakeCall(string url)
        {
            HttpResponseMessage response = await Client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                Root? result = JsonConvert.DeserializeObject<Root>(json);
                if (result != null)
                {
                    return result;
                }
            }
            throw new HttpRequestException();
        }
    }
}
