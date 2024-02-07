using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Database;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class DetailsModel : PageModel
    {

        public List<PokemonDbModel> Pokemons { get; set; }

        public string ErrorMessage { get; set; }    

        public List<Form> Forms { get; set; }

        public async Task OnGet(string name, string url)
        {

            //Form = PokemonDbModel.FirstOrDefault(form => form.Name == name);

            try

            {
                Root result = await new ApiCaller().MakeCall("pokemon-form");

                Pokemons = result.Pokemons;
            }

            catch (Exception ex) {
            
            ErrorMessage = ex.Message;
            
            }


       

    }
        


    }
}
