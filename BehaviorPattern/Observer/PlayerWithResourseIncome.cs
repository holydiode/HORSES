using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern
{
    class PlayerWithResourseIncome : IPlayer, IHaveTurnBehavior
    {
        private int _income_value;

        public PlayerWithResourseIncome(int id, int incomeValue)
        {
            ID = id;
            _income_value = incomeValue;
            Units = new();
            Resourses = new();
            Resourses.Add("золото", 0);
        }

        public int ID {get;private set;}

        public List<IUnit> Units { get; private set; }

        public Dictionary<string, int> Resourses { get; private set; }

        public IPlayer Clone()
        {
            return new PlayerWithResourseIncome(ID, _income_value) {
                Resourses = Resourses.ToDictionary(entry => entry.Key, entry => entry.Value),
                Units = Units.ToList()
            };
        }

        public void EndTurnBehavior()
        {
            Loger.GetLoger().Write("золото игрока " + ID.ToString() + " увеличилось");
            Resourses["золото"] += _income_value;
        }
    }


}
