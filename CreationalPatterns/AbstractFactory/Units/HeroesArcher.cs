using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class HeroesArcher : Unit, IArcher
    {
        private int _range;
        private int _damage;
        private int _ammunition;

        public int Range => _range;

        public int Damage => _damage;

        public HeroesArcher(Map map, string name,int range, int damage, int amunition):base(map, name)
        {
            _range = range;
            _damage = damage;
            _ammunition = amunition;
        }

        public int Shoot(int shotRange)
        {
            if (shotRange < 1)
            {
                Loger.GetLoger().Write("Стрельба в упор невозможна, урон рукопашной атаки будет уменьшен в два раза");
                return shotRange / 2;
            }
            if (_ammunition > 0)
            {
                _ammunition -= 1;
                if (shotRange > Range)
                {
                    Loger.GetLoger().Write("Дальность стрельбы привышает дальность стрелка, урон будт уменьшен в два раза");
                } 
                return shotRange < Range ? Damage : Damage / 2;
            }
            Loger.GetLoger().Write("Боезопас кончился, стрельба невозможна");
            return 0;
        }
    }
}
