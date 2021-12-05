using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class HeroesPlayerManager : PlayerManager
    {
        public HeroesPlayerManager() : base() { }
        public override void CreatePlayer()
        {
            playerQueue.Add(new HeroesPlayer(playerQueue.Count));
        }
    }
}
