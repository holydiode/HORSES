using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsesComon
{
    public enum TerainType
    {
        Earth,
        Water,
        Mount
    }

    public class Map
    {
        public List<TerainType> _terains;

        public int Size => _terains.Count;

        public Map(List<TerainType> terains)
        {
            _terains = terains;
        }

        public TerainType GetTerainType(int coords)
        {
            return _terains[coords % _terains.Count];
        }

    }
}
