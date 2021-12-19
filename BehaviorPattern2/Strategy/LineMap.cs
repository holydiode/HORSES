using System.Collections.Generic;

namespace BehaviorPattern2
{
    public class LineMap:IMap
    {
        public List<TerainType> _terains;

        public int Size => _terains.Count;

        public IPathFinder PathFinder => new LinarPathFinder();


        public LineMap(List<TerainType> terains)
        {
            _terains = terains;
        }

        public TerainType GetTerainType(int coords)
        {
            return _terains[coords];
        }
    }

}
