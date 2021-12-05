using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern.State
{
    class Unit : IUnit
    {
        private IUnitState _state;

        public void SeeAnamy()
        {
            Loger.GetLoger().Write(string.Format("Юнит {0} увидел противника", Name));
            _state.SeeEnamyBehavior();
        }

        public void SetState(IUnitState state)
        {
            _state = state;
        }

        public Unit(string name)
        {
            Name = Name;
            _state = new IgnoreUnitState(this);
        }

        public string Name { get; private set; }

        public void Move(string coord)
        {
            throw new NotImplementedException();
        }
    }
}
