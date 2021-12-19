namespace BehaviorPattern2
{
    public class CollectArmyPower : IUnitVisitor
    {
        public string VisitUnit(IUnit unit)
        {
            return "0";
        }
        public string VisitArcher(IArcher unit)
        {
            return (unit.Damage/2).ToString() ;
        }

        public string VisitСhilivary(IChilivary unit)
        {
            return (unit.Damage).ToString();
        }
    }


}
