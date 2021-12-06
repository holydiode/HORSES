using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public interface IUnitFactory
    {
        public IArcher GetArcher(Map map,string name,int range, int damage);
        public IChilivary GetChilivary(Map map, string name, int damage);
    }
}
