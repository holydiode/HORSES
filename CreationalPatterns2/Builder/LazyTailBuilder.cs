using System;

namespace CreationalPatterns2
{
    public class LazyTailBuilder : ITailBuilder
    {
        private Tail _tail;

        public LazyTailBuilder(int coord)
        {
            _tail = new Tail(coord);
            _tail.Resourses = null;
            _tail.Units = null;
        }

        public void BindMap(Map map)
        {
            _tail.Map = map;
        }

        public Tail GetTail()
        {
            return _tail;
        }

        public void PlaceUnit(int unitSeed)
        {
        }

        public void PutResourses(int resourseSeed)
        {
        }

        public void SetTerainType(int terainSeed)
        {
            TerainType[] v = (TerainType[])Enum.GetValues(typeof(TerainType));
            _tail.TerainType = (TerainType)v.GetValue(new Random().Next(v.Length));
        }
    }

}
