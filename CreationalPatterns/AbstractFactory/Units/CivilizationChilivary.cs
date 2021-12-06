using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class CivilizationChilivary : Unit, IChilivary
    {
        public int Damage { private set; get; }

        public CivilizationChilivary(Map map, string name, int damage):base(map, name)
        {
            Damage = damage;
        }

        public int Hack()
        {
            return Damage;
        }
    }
}
