using System.ComponentModel.DataAnnotations;

namespace PokeRepo.Models
{
    public class PokemonDbModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

    
    }


}
