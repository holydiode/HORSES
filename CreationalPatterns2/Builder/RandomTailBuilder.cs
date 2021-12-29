using HorsesComon;
using System;
using System.Collections.Generic;

namespace CreationalPatterns2
{
    public class RandomTailBuilder : ITailBuilder
    {
        private Tail _tail;

        public RandomTailBuilder(int coord)
        {
            _tail = new Tail(coord);
            _tail.Resourses = new Dictionary<string, int>();
            _tail.Units = new List<IUnit>();
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
            _tail.Units.Add(new Unit(new Random(unitSeed).Next().ToString()));
        }

        public void PutResourses(int resourseSeed)
        {
            _tail.Resourses.Add("золото", new Random(resourseSeed).Next(0,100));
        }

        public void SetTerainType(int terainSeed)
        {
            TerainType[] v = (TerainType[])Enum.GetValues(typeof(TerainType));
            _tail.TerainType = (TerainType)v.GetValue(new Random().Next(v.Length));
        }
    }

}
