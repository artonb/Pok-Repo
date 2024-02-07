using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> PokemonNames { get; set; }
        public string? ErrorMessage { get; set; }
        public void OnGet()
        {
            PokemonNames = Enum.GetNames(typeof(Pokemons)).ToList();

            //try
            //{
            //    Root result = await new ApiCaller().MakeCall("users");

            //    Users = result.Users;
            //}
            //catch (Exception ex)
            //{
            //    ErrorMessage = ex.Message;
            //}
            //// Anropa ett API för att hämta users

            //// 1. Skapa en ny hhtp-klient
            //HttpClient client = new();

            //// 2. Skicka ett askynkrot get request
            //HttpResponseMessage response = await client.GetAsync("https://dummyjson.com/users");

            //// 3. Se om responset var lyckat
            //if (response.IsSuccessStatusCode)
            //{
            //    // Request lyckat

            //    // 4. Läs responsets body som json
            //    string jsonStrResult = await response.Content.ReadAsStringAsync();

            //    // 5. Omvandla json-strängen till C#-objekt
            //    Root? result = JsonConvert.DeserializeObject<Root>(jsonStrResult);

            //    Users = result.Users;
            //}


            //// Displaya alla users genom att loopa genom dem

        }
    }
}