using LearnCSharp.BattleNs;

namespace LearnCSharp.Skills
{
    internal class Scratch : Skill
    {
        public Scratch() : base("Scratch")
        {
        }

        public override void Apply(BattleContext context)
        {
            context.enemyPokemon.Health -= 5;
            context.enemyPokemon.Armor -= 5;
        }
    }
}
