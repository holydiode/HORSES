using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class CivilizationArcher: Unit, IArcher
    {

        public int Range { private set; get; }
        public int Damage { private set; get; }

        public CivilizationArcher(Map map, string name, int range, int damage):base(map,name)
        {
            Range = range;
            Damage = damage;
        }
        public int Shoot(int shotRange)
        {
            if (shotRange > Range)
                Loger.GetLoger().Write("Дальность стрельбы привышает дальность стрелка, стрельба невозможна");
            return 0;
        }
    }
}
