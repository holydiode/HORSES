using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsesComon
{
    public interface IUnitFactory
    {
        public IArcher GetArcher(Map map, String name, int range, int damage);
        public IChilivary GetChilivary(Map map, String name, int damage);
    }
}
