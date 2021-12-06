using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern
{
    class PlayerWithResourseIncome : Player, IHaveTurnBehavior
    {
        private Dictionary<string,int> _income_value;

        public PlayerWithResourseIncome(int id, Dictionary<string, int> incomeValue):base(id)
        {
            _income_value = incomeValue;
            Resourses.Clear();
            Resourses = incomeValue.ToDictionary(entry => entry.Key, entry => entry.Value);
            Units = new();

        }

        public new IPlayer Clone()
        {
            return new PlayerWithResourseIncome(ID, _income_value) {
                Resourses = Resourses.ToDictionary(entry => entry.Key, entry => entry.Value),
                Units = Units.Select(item => item.Clone()).ToList()
            };
        }

        public void EndTurnBehavior()
        {
            foreach (string resourseName in _income_value.Keys)
            {
                Resourses[resourseName] += _income_value[resourseName];
            }
            Loger.GetLoger().Write("ресурсы" + ID.ToString() +" игрока увеличилось");
        }
    }
}
