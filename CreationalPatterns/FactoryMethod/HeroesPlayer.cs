using HorsesComon;
using System.Collections.Generic;
using System.Linq;

namespace CreationalPatterns
{
    public class HeroesPlayer : Player
    {
        public HeroesPlayer(int ID) : base(ID)
        {
            UnitFactory = new HeroesUnitFactory();
            InitResours();
        }
        private void InitResours()
        {
            Resourses.Clear();
            Resourses.Add("золото", 0);
            Resourses.Add("руда", 0);
            Resourses.Add("древесина", 0);
            Resourses.Add("самоцветы", 0);
            Resourses.Add("сера", 0);
            Resourses.Add("ртуть", 0);
            Resourses.Add("кристалы", 0);
        }
    }
}
