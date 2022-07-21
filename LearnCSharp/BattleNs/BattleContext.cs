namespace LearnCSharp.BattleNs
{
    internal class BattleContext
    {

        public Pokemon currentPokemon { get; }
        public Pokemon enemyPokemon { get; }
        public Trainer currentTrainer { get; }
        public Trainer enemyTrainer { get; }

        public BattleContext(Pokemon currentPokemon, Pokemon enemyPokemon, Trainer currentTrainer, Trainer enemyTrainer)
        {
            this.currentPokemon = currentPokemon;
            this.enemyPokemon = enemyPokemon;
            this.currentTrainer = currentTrainer;
            this.enemyTrainer = enemyTrainer;
        }
    }
}
