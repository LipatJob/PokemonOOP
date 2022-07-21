using LearnCSharp.BattleNs;

namespace LearnCSharp.UI
{
    internal class BattleUi
    {

        Battle battle;

        public BattleUi(Battle battle)
        {
            this.battle = battle;
        }

        public void DisplayUi()
        {
            Console.WriteLine("Current Status:");
            DisplayTrainerState(battle.Player);
            Console.WriteLine();
            DisplayTrainerState(battle.Enemy);
            Console.WriteLine();
            Console.WriteLine();

            switch (battle.currentState)
            {
                case BattleState.PlayerTurn:
                    DisplayPlayerTurn();
                    break;
                case BattleState.EnemyTurn:
                    DisplayEnemyTurn();
                    break;
                case BattleState.PlayerWon:
                    DisplayPlayerWon();
                    break;
                case BattleState.EnemyWon:
                    DisplayEnemyWon();
                    break;
                default:
                    DisplayInvalidUi();
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private void DisplayTrainerState(TrainerBattleManager trainerManager)
        {
            Console.WriteLine("Name: " + trainerManager.trainer.Name);
            Console.WriteLine("Pokemon: ");
            Console.WriteLine("  Name: " + trainerManager.FieldedPokemon.Name);
            Console.WriteLine("  Health: " + trainerManager.FieldedPokemon.Health);
        }

        private void DisplayPlayerTurn()
        {
            Console.WriteLine("Player's Turn");
            Console.WriteLine("" +
                                "Actions:\n" +
                                "1. Fight\n" +
                                "2. Change Pokemon\n" +
                                "3. Forfiet");

            Console.Write("Enter Selection: ");
            var selectedAction = Console.ReadLine();
            switch (selectedAction)
            {
                case "1":
                    DisplayFightUi(battle.Player.FieldedPokemon);
                    break;
                case "2":
                    DisplaySwapPokemonUi(battle.Player);
                    break;
                default:
                    battle.PlayerForfiet();
                    break;
            }
        }


        private void DisplaySwapPokemonUi(TrainerBattleManager trainerManager)
        {
            Console.WriteLine("Pokemons: ");
            int i = 0;
            foreach (var pokemon in trainerManager.trainer.pokemons)
            {
                Console.WriteLine($"{i} {pokemon.Name}");
                i++;
            }

            Console.Write("Enter Selection: ");
            int selectedPokemonIndex = int.Parse(Console.ReadLine());
            Pokemon selectedPokemon = trainerManager.trainer.pokemons[selectedPokemonIndex];
            trainerManager.SwapPokemon(selectedPokemon);

            var trainerName = trainerManager.trainer.Name;
            Console.WriteLine($"{trainerName} has swapped in {selectedPokemon.Name}");
        }

        private void DisplayFightUi(Pokemon pokemon)
        {
            Console.WriteLine("Skills: ");

            int i = 0;
            foreach (var skill in pokemon.Skills)
            {
                Console.WriteLine($"{i} {skill.Name}");
                i++;
            }
            Console.Write("Enter Selection: ");


            int selectedSkillIndex = int.Parse(Console.ReadLine());
            Skill selectedSkill = pokemon.Skills.ElementAt(selectedSkillIndex);
            selectedSkill.Apply(battle.GetContext());
            Console.WriteLine($"{pokemon.Name} used {selectedSkill.Name}");
        }

        private void DisplayEnemyTurn()
        {
            Console.WriteLine("Enemy's Turn");
            Console.WriteLine("" +
                                "Select Action:\n" +
                                "1. Fight\n" +
                                "2. Change Pokemon\n" +
                                "3. Forfiet");
            Console.Write("Enter Selection: ");
            var selectedAction = Console.ReadLine();
            switch (selectedAction)
            {
                case "1":
                    DisplayFightUi(battle.Enemy.FieldedPokemon);
                    break;
                case "2":
                    DisplaySwapPokemonUi(battle.Enemy);
                    break;
                default:
                    battle.PlayerForfiet();
                    break;
            }
        }

        private void DisplayPlayerWon()
        {
            Console.WriteLine("Player Won :D");
        }

        private void DisplayEnemyWon()
        {
            Console.WriteLine("Enemy Lost :(");
        }

        private void DisplayInvalidUi()
        {
            Console.WriteLine("Something went wrong :(");
        }
    }
}
