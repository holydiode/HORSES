using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public interface IArcher
    {
        public int Range {get;}
        public int Damage {get;}
        public int Shoot(int shotRange);

    }
}
