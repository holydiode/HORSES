using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class CivilizationArcher: IArcher
    {
        private int _range;
        private int _damage;
        public int Range => _range;
        public int Damage => _damage;

        public CivilizationArcher(int range, int damage)
        {
            _range = range;
            _damage = damage;
        }
        public int Shoot(int shotRange)
        {
            if (shotRange > Range)
                Loger.GetLoger().Write("Дальность стрельбы привышает дальность стрелка, стрельба невозможна");
            return 0;
        }
    }
}
