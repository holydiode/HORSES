using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace HORSES
{
    interface IPlayerManager
    {
        public Player CurentPlayer { get;}

        public void EndTurn();

        public void AddPlayer(Player player); 
    }
    
    
    class GameMaster: IPlayerManager{

        private static GameMaster _istance = null;

        public Player CurentPlayer => _playerManager.CurentPlayer;

        private IPlayerManager _playerManager;

        public void AddPlayer(Player player) {
            _playerManager.AddPlayer(player);
            Loger.GetLoger().Write("Игрок " + player.ID.ToString() + " Добавлен в игру");
        }

        public void EndTurn()
        {
            Loger.GetLoger().Write("Ход игрока " + CurentPlayer.ID.ToString() + "закончен");
            _playerManager.EndTurn();
            Loger.GetLoger().Write("Начаслся ход игрока " + CurentPlayer.ID.ToString() );
        }

        private GameMaster()
        {
            _playerManager = new PlayerManager();
        }

        public static GameMaster GetMaster()
        {
            if (GameMaster._istance is null)
            {
                GameMaster._istance = new GameMaster();
            }
            return GameMaster._istance;
        }
    }

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
