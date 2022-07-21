using LearnCSharp.BattleNs;

namespace LearnCSharp.Skills
{
    internal class Roar : Skill
    {
        public Roar() : base("Roar") { }

        public override void Apply(BattleContext context)
        {
            context.enemyPokemon.Armor -= 10;
        }
    }
}
