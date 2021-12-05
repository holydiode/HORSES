using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern
{
    public interface  IPlayer
    {
        public int ID {get;}
        public List<IUnit> Units { get; }
        public Dictionary<string,int> Resourses {get;}
        public IPlayer Clone();
    }
}
