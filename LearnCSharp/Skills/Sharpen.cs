namespace LearnCSharp.Skills;
using LearnCSharp.BattleNs;

internal class Sharpen : Skill
{
    public Sharpen() : base("Sharpen")
    {
    }

    public override void Apply(BattleContext context)
    {
        context.currentPokemon.Strength += 10;
    }
}
