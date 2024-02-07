namespace PokeRepo.Models
{
    public class PokemonRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        // Forms list
        public List<Form> Forms {  get; set; }  

    }

    public class Form
    {
        public string Name { get; set; }
        public string Url { get; set; } 
    }
}
