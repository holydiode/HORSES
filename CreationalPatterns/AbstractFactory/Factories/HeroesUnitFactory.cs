using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class HeroesUnitFactory : IUnitFactory
    {
        public IArcher GetArcher(int range, int damage)
        {
            Loger.GetLoger().Write(string.Format("юнит типа {0} для игры герои меча и магии создан", "Лучник"));
            return new HeroesArcher(range, damage, 2);
        }

        public IChilivary GetChilivary(int damage)
        {
            Loger.GetLoger().Write(string.Format("юнит типа {0} для игры герои меча и магии   создан", "Рыцарь"));
            return new HeroesChiliavry(damage);
        }


    }
}
