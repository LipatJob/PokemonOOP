using LearnCSharp.Skills;

namespace LearnCSharp.Pokemons
{
    internal class Zigzagoon : Pokemon
    {
        public Zigzagoon() : base(
            name: "Zigzagoon",
            level: 1,
            health: 100,
            armor: 5,
            strength: 2,
            skills: new List<Skill>() {
                new Scratch(),
                new Heal(),
            }
        )
        { }
    }
}
