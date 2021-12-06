using System;

namespace CreationalPatterns
{
    public abstract class UnitUpgrade : IUnit
    {
        protected IUnit _coreUnit; 

        public UnitUpgrade(IUnit coreUnit)
        {
            _coreUnit = coreUnit;
        }

        public virtual string Name => _coreUnit.Name;

        public HorsesComon.Map Map => _coreUnit.Map;

        public int Position => _coreUnit.Position;

        public abstract IUnit Clone();

        public virtual void MoveTo(int coord)
        {
        }

        public virtual void MoveTo(string coord)
        {
        }

        public void Rearrange(int coord)
        {
            _coreUnit.Rearrange(coord);
        }
    }
}
