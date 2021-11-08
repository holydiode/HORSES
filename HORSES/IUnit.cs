namespace HORSES
{
    interface IUnit
    {
        public string Name { get; }
        public void Move(string coord);
    }
}
