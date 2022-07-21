using LearnCSharp.BattleNs;

namespace LearnCSharp
{
    abstract class Skill
    {
        public string Name { get; }

        protected Skill(string name)
        {
            Name = name;
        }

        public abstract void Apply(BattleContext context);
    }
}