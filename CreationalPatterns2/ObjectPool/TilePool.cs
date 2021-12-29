using HorsesComon;
using System.Collections.Generic;

namespace CreationalPatterns2
{
    public class TilePool
    {
        private Dictionary<int, Tail> _tails;
        public TilePool()
        {
            _tails = new();
        }
        public void PutTitle(Tail tail)
        {
            if (_tails.ContainsKey(tail.Coord))
            {
                _tails[tail.Coord] = tail;
            }
            else
            {
                _tails.Add(tail.Coord, tail);
                Loger.GetLoger().Write("Тайл с координатами {0} положен в пул", tail.Coord);
            }
        }
        public Tail TakeTile(int coord)
        {
            Loger.GetLoger().Write("Тайл с координатами {0} взят из пула", coord);
            return _tails[coord];
        }

        public bool Contains(int coord)
        {
            return _tails.ContainsKey(coord);
        }
    }

}
