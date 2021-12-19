using System;

namespace BehaviorPattern2
{
    public class LinarPathFinder: IPathFinder
    {
        public int FindPath(int firstPoint, int secondPoint, IMap map)
        {
            return Math.Min(firstPoint + 1, secondPoint);
        }
    }

}
