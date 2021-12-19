using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern2
{
    public interface IArcher: IUnit
    {
        public int Range {get;}
        public int Damage {get;}
        public int Shoot(int shotRange);

    }
}
