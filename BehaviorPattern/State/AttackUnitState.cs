using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern.State
{
    class AttackUnitState : IUnitState
    {
        private IUnit _unit;

        public AttackUnitState(IUnit unit)
        {
            _unit = unit;
        }

        public void SeeEnamyBehavior()
        {
            Loger.GetLoger().Write(string.Format("Юнит {0} будет атаковть противника" , _unit.Name));
        }
    }

    class ProtectUnitState : IUnitState
    {
        private IUnit _unit;

        public ProtectUnitState(IUnit unit)
        {
            _unit = unit;
        }
        public void SeeEnamyBehavior()
        {
            Loger.GetLoger().Write(string.Format("Юнит {0} будетатаковать по возможности противника", _unit.Name));
        }
    }

    class IgnoreUnitState : IUnitState
    {
        private IUnit _unit;

        public IgnoreUnitState(IUnit unit)
        {
            _unit = unit;
        }
        public void SeeEnamyBehavior()
        {
        }
    }

}
