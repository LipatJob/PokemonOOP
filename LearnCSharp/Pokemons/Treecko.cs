using LearnCSharp.Skills;

namespace LearnCSharp.Pokemons
{
    internal class Treecko : Pokemon
    {
        public Treecko() : base(
            name: "Treecko",
            level: 1,
            health: 100,
            armor: 5,
            strength: 2,
            skills: new List<Skill>() {
                new Swipe(),
                new Roar(),
            }
        )
        {

        }
    }
}
