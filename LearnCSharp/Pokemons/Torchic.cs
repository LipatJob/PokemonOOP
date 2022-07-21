using LearnCSharp.Skills;

namespace LearnCSharp.Pokemons
{
    internal class Torchic : Pokemon
    {
        public Torchic() : base(
            name: "Torchic",
            level: 1,
            health: 100,
            armor: 5,
            strength: 2,
            skills: new List<Skill>() {
                new Swipe(),
                new Sharpen(),
            }
        )
        {
        }
    }
}
