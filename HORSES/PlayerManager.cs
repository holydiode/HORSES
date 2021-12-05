using System.Collections.Generic;




namespace HORSES
{
    class PlayerManager : IPlayerManager {

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
    }

}
