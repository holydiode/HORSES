using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsesComon
{
    public interface  IPlayer
    {
        public int ID {get;}
        public List<IUnit> Units { get; }
        public IUnitFactory UnitFactory { get; }
        public Dictionary<string,int> Resourses {get;}
        bool IsInGame { get; }
        public Map Map { get;}
        public void Lose();
        public IPlayer Clone();
        public IUnit ProductUnit(string unitName);

    }
}
