using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public interface  IPlayer
    {
        public int ID {get;}
        public List<IUnit> Units{ get;}  
        public Dictionary<string,int> Resourses {get;}
        public List<IUnit> Builds {get;}
        public IArcher GetArcher(int range, int damage);
        public IChilivary GetChilivary(int damage);
    }
}
