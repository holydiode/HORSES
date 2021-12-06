using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    class CivilizationUnitFactory : IUnitFactory
    {
        public IArcher GetArcher(Map map, string name, int range, int damage)
        {
            Loger.GetLoger().Write(string.Format("юнит типа {0} для игры цивилизация создан", "Лучник"));
            return new CivilizationArcher(map, name, range, damage);
        }

        public IChilivary GetChilivary(Map map, string name,int damage)
        {
            Loger.GetLoger().Write(string.Format("юнит типа {0} для игры цивилизация создан", "Рыцарь"));
            return new CivilizationChilivary(map, name, damage);
        }


    }
}
