using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class CivilizationChilivary : IChilivary
    {
        private int _damage;
        public int Damage => _damage;

        public CivilizationChilivary(int damage)
        {
            _damage = damage;
        }

        public int Hack()
        {
            return _damage;
        }
    }
}
