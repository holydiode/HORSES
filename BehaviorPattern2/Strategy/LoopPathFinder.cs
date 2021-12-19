namespace BehaviorPattern2
{
    public class LoopPathFinder: IPathFinder
    {
        public int FindPath(int firstPoint, int secondPoint, IMap map)
        {
            if (secondPoint > firstPoint)
            {
                if ((secondPoint - firstPoint) < map.Size / 2)
                {
                    return firstPoint + 1;
                }
                else
                {
                    return firstPoint - 1 < 0 ? map.Size - 1 : firstPoint - 1;
                }
            }
            else
            {
                if (( firstPoint  - secondPoint) < map.Size / 2)
                {
                    return firstPoint - 1;
                }
                else
                {
                    return firstPoint + 1 >=  map.Size ? 0 : firstPoint + 1;
                }
            }
        }
    }

}
