using LearnCSharp;
using LearnCSharp.Pokemons;
using LearnCSharp.UI;

var battle = new Battle(
    player: new Trainer(
            name: "Drew",
            pokemons: new List<Pokemon>{
                new Mudkip(),
                new Treecko()
            }
        ),
    enemy: new Trainer(
            name: "May",
            pokemons: new List<Pokemon>{
                new Torchic()
            }
        )
); ;

var battleUi = new BattleUi(battle);

while (true)
{
    battleUi.DisplayUi();
    battle.NextState();
    Console.WriteLine("Press any key to continue....");
    Console.ReadKey();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}