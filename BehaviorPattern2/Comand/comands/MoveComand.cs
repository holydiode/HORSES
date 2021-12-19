using HorsesComon;

namespace BehaviorPattern2
{
    class MoveComand : IComand
    {
        public string Name => "переместится";

        private IUnit _unit;

        public MoveComand(IUnit unit)
        {
            _unit = unit;
        }

        public void Execute(int parametr)
        {
            _unit.MoveTo(parametr);
        }
    }

}
