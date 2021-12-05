using System.Collections;
using System.Collections.Generic;
using HorsesComon;



namespace Structural_pattern
{

    class PlayerManager: IEnumerable<Player> {

        private List<Player> playerQueue;
        public Player CurentPlayer => playerQueue[0];
        public PlayerManager()
        {
            playerQueue = new();
        }
        public void AddPlayer(Player player)
        {
            playerQueue.Add(player);
            Loger.GetLoger().Write("Менеджер игроков обработал добавление игрока");
        }
        public void EndTurn()
        {
            Loger.GetLoger().Write("Менеджер игроков обработал заершеие хода");
            LoopSwap();
        }
        private void LoopSwap()
        {
            Player end_turn_player = CurentPlayer;
            playerQueue.RemoveAt(0);
            playerQueue.Add(end_turn_player);

        }

        public IEnumerator<Player> GetEnumerator()
        {
            return new PlayerManagerIterator(playerQueue);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PlayerManagerIterator(playerQueue);
        }
    }

}
