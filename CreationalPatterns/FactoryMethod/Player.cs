using System.Collections.Generic;

namespace CreationalPatterns
{
    public class Player : IPlayer
    {
        private IUnitFactory _unitFactry;

        public Player(int ID, IUnitFactory unitFactory)
        {
            this.ID = ID;
            Units = new();
            Builds = new();
            _unitFactry = unitFactory;

            Resourses = new Dictionary<string, int>();
            InitResours();
        }

        private void InitResours()
        {
            Resourses.Add("золото", 0); 
            Resourses.Add("древесина", 0); 
            Resourses.Add("руда", 0); 
        }

        public IArcher GetArcher(int range, int damage)
        {
            return _unitFactry.GetArcher(range, damage);
        }

        public IChilivary GetChilivary(int damage)
        {
            throw new System.NotImplementedException();
        }

        public int ID { get; private set; }

        public List<IUnit> Units { get; private set; }

        public List<IUnit> Builds { get; private set; }

        public Dictionary<string, int> Resourses { get; private set;}
    }
}
