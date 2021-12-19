using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern2
{
    class HeroesChiliavry : Unit, IChilivary
    {
        public int Damage { get; private set; }

        public HeroesChiliavry(IMap map, string name,int damage):base(map, name)
        {
            Damage = damage;
            Comands.Add(new HackComand(this));
        }
        public int Hack()
        {
            Random rg = new ();
            int damage = (rg.NextDouble() > 0.5) ? Damage : Damage * 2;
            Loger.GetLoger().Write("Юнит рубит и наносит " + damage.ToString() + " урона");
            return damage;
        }

        public override string AcceptVisitor(IUnitVisitor visitor)
        {
            return visitor.VisitСhilivary(this);
        }


    }
}
