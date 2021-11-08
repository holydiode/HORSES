namespace HORSES
{
    class Unit : IUnit
    {
        public Player Owner{ private set; get;}
        public string Name { private set; get;}
        public Unit(Player owner, string name)
        {
            Owner = owner;
            Name = name;
            Loger.GetLoger().Write("Создан юнит " + Name + " пренадлежащий игроку " + owner.ID.ToString() );
        }
        public void Move(string coord)
        {
            Loger.GetLoger().Write("Юнит " + Name + " переместился по координатам " + coord + ".");
        }
    }
}
