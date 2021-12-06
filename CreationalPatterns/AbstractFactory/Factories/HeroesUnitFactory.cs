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
        public IArcher GetArcher(Map map, string name, int range, int damage)
        {
            Loger.GetLoger().Write(string.Format("юнит типа {0} для игры герои меча и магии создан", "Лучник"));
            return new HeroesArcher(map, name, range, damage, 2);
        }

        public IChilivary GetChilivary(Map map, string name, int damage)
        {
            Loger.GetLoger().Write(string.Format("юнит типа {0} для игры герои меча и магии   создан", "Рыцарь"));
            return new HeroesChiliavry(map, name, damage);
        }


    }
}
