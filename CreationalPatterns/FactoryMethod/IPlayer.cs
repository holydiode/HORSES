using System.Collections.Generic;

namespace CreationalPatterns
{
    public interface IPlayer
    {
        public int ID { get; }
        public List<IUnit> Units { get; }
        public IUnitFactory UnitFactory { get;}
        public HorsesComon.Map Map { get;}
        public Dictionary<string, int> Resourses { get; }
        public IPlayer Clone();
        public IUnit ProductUnit(string unitName);

    }
}