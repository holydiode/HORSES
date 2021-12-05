using System.Collections.Generic;

namespace CreationalPatterns
{
    public class HeroesPlayer : IPlayer
    {
        public HeroesPlayer(int ID)
        {
            this.ID = ID;
            Units = new();
            Builds = new();

            Resourses = new Dictionary<string, int>();
            InitResours();
        }

        private void InitResours()
        {
            Resourses.Add("золото", 0);
            Resourses.Add("руда", 0);
            Resourses.Add("древесина", 0);
            Resourses.Add("самоцветы", 0);
            Resourses.Add("сера", 0);
            Resourses.Add("ртуть", 0);
            Resourses.Add("кристалы", 0);
        }

        public int ID { get; private set; }

        public List<IUnit> Units { get; private set; }

        public List<IUnit> Builds { get; private set; }

        public Dictionary<string, int> Resourses { get; private set; }
        
        public IArcher GetArcher(int range, int damage)
        {
            return new HeroesUnitFactory().GetArcher(range, damage);
        }

        public IChilivary GetChilivary(int damage)
        {
            return new HeroesUnitFactory().GetChilivary( damage);
        }

    }
}
