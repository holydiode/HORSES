using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class HeroesChiliavry : Unit, IChilivary
    {
        public int Damage { get; private set; }

        public HeroesChiliavry(Map map, string name,int damage):base(map, name)
        {
            Damage = damage;
        }
        public int Hack()
        {
            Random rg = new ();
            return (rg.NextDouble() > 0.5) ? Damage : Damage * 2;
        }
        int IChilivary.Hack()
        {
            throw new NotImplementedException();
        }
    }
}
