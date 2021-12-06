using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern
{

    public class GameMaster
    {

        private List<IHaveTurnBehavior> _haveTurnsObjects;

        private static GameMaster _istance = null;
        public IPlayer CurentPlayer => _playerManager.CurentPlayer;

        private PlayerManager _playerManager;

        public void AddPlayer(IPlayer player)
        {
            _playerManager.AddPlayer(player);
            Loger.GetLoger().Write("Игрок " + player.ID.ToString() + " Добавлен в игру");
        }

        public void EndTurn()
        {
            Loger.GetLoger().Write("Ход игрока " + CurentPlayer.ID.ToString() + "закончен");
            _playerManager.EndTurn();
            Loger.GetLoger().Write("Начаслся ход игрока " + CurentPlayer.ID.ToString());
            foreach (IHaveTurnBehavior haveTurnBehavior in _haveTurnsObjects)
                haveTurnBehavior.EndTurnBehavior();
        }

        private GameMaster()
        {
            Loger.GetLoger().Write("инициализация мастера игры");
            _playerManager = new PlayerManager();
            _haveTurnsObjects = new();
        }

        public void SubscribeEndBehaivor(IHaveTurnBehavior turnObject)
        {
            Loger.GetLoger().Write("Объект подписан");
            _haveTurnsObjects.Add(turnObject);
        }

        public void UnsubscribeEndBehaivor(IHaveTurnBehavior turnObject)
        {
            Loger.GetLoger().Write("Объект отписан");
            _haveTurnsObjects.Remove(turnObject);
        }

        public static GameMaster GetMaster() => GameMaster._istance ??= new GameMaster();

        public GameMasterSnapShot SaveState()
        {
            return new GameMasterSnapShot(_playerManager.playerQueue);
        }

        internal void LoadState(GameMasterSnapShot gameMasterSnapShot)
        {
            _playerManager.playerQueue.Clear();
            foreach (IPlayer player in gameMasterSnapShot.copyPlayer)
            {
                AddPlayer(player);
            }
        }

        public class GameMasterSnapShot
        {
            public GameMasterSnapShot(List<IPlayer> players)
            {
                copyPlayer = players.Select(item => item.Clone()).ToList();
            }

            internal List<IPlayer> copyPlayer;
        }

    }
}
