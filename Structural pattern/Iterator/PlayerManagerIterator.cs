using System.Collections;
using System.Collections.Generic;
using HorsesComon;



namespace Structural_pattern
{
    public class PlayerManagerIterator : IEnumerator<Player>
    {
        private List<Player> _playerQueue;
        private int _curPouse = -1;

        public PlayerManagerIterator(List<Player> playerQueue)
        {
            _playerQueue = playerQueue;
        }

        public Player Current => _playerQueue[_curPouse];

        object IEnumerator.Current => _playerQueue[_curPouse];

        public void Dispose()
        {
            Loger.GetLoger().Write("Итератор закончил перечесление");
        }

        public bool MoveNext()
        {
            do
            {
                _curPouse++;
            } while (_curPouse < _playerQueue.Count && _playerQueue[_curPouse].IsInGame == false);
            return _curPouse < _playerQueue.Count;
        }

        public void Reset()
        {
            _curPouse = -1;
        }
    }

}
