using System;
using System.Collections.Generic;

namespace BehaviorPattern2
{
    public class CollectInfo: IUnitVisitor
    {
        public string VisitUnit(IUnit unit)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Положение", unit.Position.ToString());
            return string.Join(Environment.NewLine, dict);
        }
        public string VisitArcher(IArcher unit)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Положение", unit.Position.ToString());
            dict.Add("Дальность стрельбы", unit.Range.ToString());
            dict.Add("Урон", unit.Damage.ToString());
            return string.Join(Environment.NewLine, dict);
        }

        public string VisitСhilivary(IChilivary unit)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Положение", unit.Position.ToString());
            dict.Add("Урон", unit.Damage.ToString());
            return string.Join(Environment.NewLine, dict);
        }
    }


}
