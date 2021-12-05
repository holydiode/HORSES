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
        public IArcher GetArcher(int range, int damage)
        {
            Loger.GetLoger().Write(string.Format("юнит типа {0} для игры цивилизация создан", "Лучник"));
            return new CivilizationArcher(range, damage);
        }

        public IChilivary GetChilivary(int damage)
        {
            Loger.GetLoger().Write(string.Format("юнит типа {0} для игры цивилизация создан", "Рыцарь"));
            return new CivilizationChilivary(damage);
        }


    }
}
