using System.Collections;
using System.Collections.Generic;
using HorsesComon;



namespace HorsesComon
{
    public class PlayerManagerIterator : IEnumerator<IPlayer>
    {
        private List<IPlayer> _playerQueue;
        private int _curPouse = -1;

        public PlayerManagerIterator(List<IPlayer> playerQueue)
        {
            _playerQueue = playerQueue;
        }

        public IPlayer Current => _playerQueue[_curPouse];

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
