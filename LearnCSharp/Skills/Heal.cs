using LearnCSharp.BattleNs;

namespace LearnCSharp.Skills
{
    internal class Heal : Skill
    {
        public Heal() : base("Jump")
        {
        }

        public override void Apply(BattleContext context)
        {
            context.currentPokemon.Health += 10;
        }
    }
}
