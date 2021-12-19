using System.Collections.Generic;

namespace BehaviorPattern2
{
    public class LoopMap : IMap
    {
        public List<TerainType> _terains;

        public int Size => _terains.Count;

        public IPathFinder PathFinder => new LoopPathFinder();

        public LoopMap(List<TerainType> terains)
        {
            _terains = terains;
        }

        public TerainType GetTerainType(int coords)
        {
            return _terains[coords];
        }
    }

}
