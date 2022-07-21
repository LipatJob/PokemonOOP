namespace LearnCSharp
{
    internal class Trainer
    {
        public string Name { get; }
        public List<Pokemon> pokemons { get; }

        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            this.pokemons = pokemons;
        }
    }
}
