using HorsesComon;

namespace BehaviorPattern2
{
    public interface IUnit
    {
        public string Name {get;}
        public IMap Map {get;}
        public string AcceptVisitor(IUnitVisitor visitor);
        public ComandRoster Comands { get; }
        public int Position { get;}
        public void MoveTo(int coord);
        public void MoveTo(string coord);
        public void Rearrange(int coord);
        public IUnit Clone();
    }
}
