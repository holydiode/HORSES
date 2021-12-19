using HorsesComon;

namespace BehaviorPattern2
{
    class ShootComand : IComand
    {
        public string Name => "переместится";

        private IArcher _unit;

        public ShootComand(IArcher unit)
        {
            _unit = unit;
        }

        public void Execute(int parametr)
        {
            _unit.Shoot(parametr);
        }
    }

}
