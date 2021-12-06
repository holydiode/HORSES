using HorsesComon;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CreationalPatterns
{




    public class GameMaster{

        private static GameMaster _istance = null;

        public IPlayer CurentPlayer => _playerManager.CurentPlayer;

        private PlayerManager _playerManager;

        public void AddPlayer(IPlayer player) {
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
            Loger.GetLoger().Write("инициализация мастера игры");
            _playerManager = new PlayerManager();
        }

        public static GameMaster GetMaster() => GameMaster._istance ??= new GameMaster();
    }

}
