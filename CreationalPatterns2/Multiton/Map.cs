using HorsesComon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns2
{

    public class Map
    {

        private static Dictionary<string, Map> _maps = new();

        private TilePool _tiles;

        private Map()
        {
            _tiles = new();
        }

        public static Map GetMap(string name)
        {
            if (!_maps.ContainsKey(name))
            {
                _maps.Add(name, new Map());
                Loger.GetLoger().Write("Новая карта {0} проинициализированна", name);
            }

            return _maps.GetValueOrDefault(name);
        }

        public static Map GetMap()
        {
            if (_maps.Count == 0)
            {
                _maps.Add("", new Map());
            }
            return _maps.Last().Value;
        }

        public Tail GetTile(int coord)
        {
            if (_tiles.Contains(coord))
            {
                return _tiles.TakeTile(coord);
            }
            Tail tail = new TailDirector(new LazyTailBuilder(coord), this, coord).GetTail();
            _tiles.PutTitle(tail);
            return tail;
        }

        public Tail LoadTile(int coord)
        {
            return new TailDirector(new RandomTailBuilder(coord), this, coord).GetTail();
        }

        public TerainType GetTerainType(int coords)
        {
            return TerainType.Earth;
        }

    }

}
