namespace CreationalPatterns
{
    public interface IUnit
    {
        public string Name {get;}
        public Map Map {get;}
        public int Position { get;}
        public void MoveTo(int coord);
        public void MoveTo(string coord);
        public void Rearrange(int coord);

        public IUnit Clone();
    }
}
