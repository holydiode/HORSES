namespace BehaviorPattern
{
    public interface IUnit
    {
        public string Name { get; }
        public void Move(string coord);
    }
}
