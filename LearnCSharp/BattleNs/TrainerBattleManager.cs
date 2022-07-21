namespace LearnCSharp.BattleNs
{
    internal class TrainerBattleManager
    {
        public Trainer trainer;
        public Pokemon FieldedPokemon { get; private set; }

        public TrainerBattleManager(Trainer trainer)
        {
            this.trainer = trainer;
            FieldedPokemon = GetFirstNotFaintedPokemon();
        }


        private Pokemon GetFirstNotFaintedPokemon()
        {
            return trainer.pokemons.Where(pokemon => !pokemon.Fainted).First();
        }

        public void SwapPokemon(Pokemon pokemon)
        {
            if (!trainer.pokemons.Contains(pokemon))
            {
                throw new ArgumentException($"This pokemon is not owned by the trainer. Pokemon: {pokemon.Name}, Trainer: {trainer.Name}");
            }

            FieldedPokemon = pokemon;
        }

        public bool HasNoPokemonsLeft()
        {
            return trainer.pokemons.All(e => e.Health <= 0);
        }


    }
}
