using LearnCSharp.Skills;

namespace LearnCSharp.Pokemons
{
    internal class Mudkip : Pokemon
    {
        public Mudkip() : base(
            name: "Mudkip",
            level: 1,
            health: 100,
            armor: 5,
            strength: 5,
            skills: new List<Skill>() {
                new Swipe(),
            }
        )
        {
        }
    }
}
