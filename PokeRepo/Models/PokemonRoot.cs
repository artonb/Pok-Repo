namespace PokeRepo.Models
{
    public class Root
    {
        public List<PokemonDbModel> Pokemons { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        // Forms list
        public List<Form> Forms { get; set; }

    }

    public class Form
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public Form(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
