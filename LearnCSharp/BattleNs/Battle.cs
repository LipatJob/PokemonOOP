using LearnCSharp.BattleNs;

namespace LearnCSharp
{
    enum BattleState { PlayerTurn, EnemyTurn, PlayerWon, EnemyWon }

    internal class Battle
    {
        public TrainerBattleManager Player { get; }
        public TrainerBattleManager Enemy { get; }
        public BattleState currentState { get; private set; }

        public Battle(Trainer player, Trainer enemy)
        {
            this.Player = new(player);
            this.Enemy = new(enemy);
            currentState = BattleState.PlayerTurn;
        }

        public void NextState()
        {
            BattleState nextState = BattleState.PlayerTurn;
            if (Enemy.HasNoPokemonsLeft())
            {
                nextState = BattleState.PlayerWon;
            }
            else if (Player.HasNoPokemonsLeft())
            {
                nextState = BattleState.EnemyWon;
            }
            else if (currentState == BattleState.PlayerTurn)
            {
                nextState = BattleState.EnemyTurn;
            }
            else if (currentState == BattleState.EnemyTurn)
            {
                nextState = BattleState.PlayerTurn;
            }
            currentState = nextState;
        }

        public void PlayerForfiet()
        {
            currentState = BattleState.EnemyWon;
        }

        public void EnemyForfiet()
        {
            currentState = BattleState.PlayerWon;
        }

        public BattleContext GetContext()
        {
            if (currentState == BattleState.PlayerTurn)
            {
                return new BattleContext(
                    currentPokemon: Player.FieldedPokemon,
                    enemyPokemon: Enemy.FieldedPokemon,
                    currentTrainer: Player.trainer,
                    enemyTrainer: Enemy.trainer
                );
            }
            else
            {
                return new BattleContext(
                        currentPokemon: Enemy.FieldedPokemon,
                        enemyPokemon: Player.FieldedPokemon,
                        currentTrainer: Enemy.trainer,
                        enemyTrainer: Player.trainer
                    );
            }
        }
    }
}
