using LearnCSharp.BattleNs;

namespace LearnCSharp.Skills
{
    internal class Swipe : Skill
    {
        public Swipe() : base("Swipe")
        {
        }

        public override void Apply(BattleContext context)
        {
            context.enemyPokemon.Health -= 10 + context.currentPokemon.Strength;
        }
    }
}
