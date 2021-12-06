using System.Collections;
using System.Collections.Generic;
using HorsesComon;



namespace HorsesComon
{

    public class PlayerManager: IEnumerable<IPlayer> {

        public List<IPlayer> playerQueue;
        public IPlayer CurentPlayer => playerQueue[0];
        public PlayerManager()
        {
            playerQueue = new();
        }
        public void AddPlayer(IPlayer player)
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
            IPlayer end_turn_player = CurentPlayer;
            playerQueue.RemoveAt(0);
            playerQueue.Add(end_turn_player);

        }

        public IEnumerator<IPlayer> GetEnumerator()
        {
            return new PlayerManagerIterator(playerQueue);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PlayerManagerIterator(playerQueue);
        }
    }

}
