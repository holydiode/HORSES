using HorsesComon;

namespace CreationalPatterns
{
    public class FlyableUnit: UnitUpgrade
    {
        private int _fuel = 0;
        public FlyableUnit(IUnit coreUnit): base(coreUnit){}
        public FlyableUnit(IUnit coreUnit, int fuel):base(coreUnit)
        {
            _fuel = fuel;
        }
        public override void MoveTo(int coord)
        {
            int flyValue = _fuel > (coord - Position) ? (coord - Position) : _fuel;
            _fuel -= flyValue;
            if (_fuel < 1)
                Loger.GetLoger().Write(string.Format("У юнита {0} закончилось топливо", Name));
            Loger.GetLoger().Write(string.Format("Юнит {0} пролетел {1} клеток", Name, flyValue));
            Rearrange(Position + flyValue);
            _coreUnit.MoveTo(coord);
        }
        public override IUnit Clone()
        {
            return new FlyableUnit(_coreUnit.Clone()) { _fuel = this._fuel} ;
        }

    }
}
