using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorsesComon;

namespace Structural_pattern
{
    class ManagableGroup: IUnit
    {
        private IEnumerable<IUnit> _units;
        private string _name;
        public ManagableGroup(IEnumerable<IUnit> units, string name)
        {
            _units = units;
            _name = name;
        }

        public string Name => _name;

        public Map Map => _units.First().Map;

        public int Position => 0;

        public void MoveTo(int coord)
        {
            Loger.GetLoger().Write("Управляемая группа " + this.Name + " передвигается на координаты " + coord.ToString());
            foreach(IUnit curentUnit in _units)
            {
                curentUnit.MoveTo(coord);
            }
        }

        public void MoveTo(string coord)
        {
            Loger.GetLoger().Write("Управляемая группа " + this.Name + "передвигается на координаты");
            foreach (IUnit curentUnit in _units)
            {
                curentUnit.MoveTo(coord);
            }
        }

        public void Rearrange(int coord)
        {
            Loger.GetLoger().Write("Управляемая группа " + this.Name + "перемещается на координаты");
            foreach (IUnit curentUnit in _units)
            {
                curentUnit.Rearrange(coord);
            }
        }
    }

}
