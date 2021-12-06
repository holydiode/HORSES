using HorsesComon;
using System.Collections.Generic;




namespace CreationalPatterns
{
    public class PlayerManager{

        protected List<IPlayer> playerQueue;
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

        public virtual void CreatePlayer() {

            playerQueue.Add(new Player(playerQueue.Count, new CivilizationUnitFactory()));
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


    }

}
