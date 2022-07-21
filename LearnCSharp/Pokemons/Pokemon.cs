namespace LearnCSharp;

abstract class Pokemon
{
    public string Name { get; }
    public int Level { get; }
    public int Health { get; set; }
    public int Armor { get; set; }
    public int Strength { get; set; }
    public IEnumerable<Skill> Skills { get; }
    public bool Fainted => Health <= 0;

    protected Pokemon(string name, int level, int health, int armor, int strength, IEnumerable<Skill> skills)
    {
        Name = name;
        Level = level;
        Health = health;
        Armor = armor;
        Skills = skills;
        Strength = strength;
    }


    public void UseSkill(Skill skill, Battle battle)
    {
        skill.Apply(battle.GetContext());
    }



}
