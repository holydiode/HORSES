using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class HeroesChiliavry : IChilivary
    {
        private int _damage;
        public int Damage => _damage;
        public HeroesChiliavry(int damage)
        {
            _damage = damage;
        }
        public int Hack()
        {
            Random rg = new Random();
            return (rg.NextDouble() > 0.5) ? _damage : _damage * 2;
        }
    }
}
