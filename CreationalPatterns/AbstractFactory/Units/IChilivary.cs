using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public interface IChilivary : IUnit
    {
        public int Damage {get;}
        public int Hack();
    }
}
