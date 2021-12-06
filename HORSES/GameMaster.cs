

namespace HORSES
{
    class GameMaster{

        private static GameMaster _istance = null;

        public Player CurentPlayer => _playerManager.CurentPlayer;

        private PlayerManager _playerManager;

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

}
