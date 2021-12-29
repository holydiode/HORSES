using HorsesComon;

namespace HorsesComon
{
    class HackComand : IComand
    {
        public string Name => "переместится";

        private IChilivary _unit;

        public HackComand(IChilivary unit)
        {
            _unit = unit;
        }

        public void Execute(int parametr)
        {
            _unit.Hack();
        }
    }

}
