using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern.State
{
    class Unit : HorsesComon.IUnit
    {
        public IUnitState State { protected get;  set; }

        public void SeeEnamy(int coord)
        {
            State.SeeEnamyBehavior(coord);
        }

        public string Name { private set; get; }

        public Map Map { private set; get; }

        public int Position { private set; get; }

        public Unit(Map map, string name)
        {
            Name = name;
            Map = map;
            Position = 0;
            State = new ProtectUnitState(this);
        }

        public void MoveTo(int coord)
        {
            while (Position != coord)
            {
                if (Map.GetTerainType(Position + 1) == TerainType.Water)
                {
                    Loger.GetLoger().Write(string.Format("Юнит {0} не может плыть, движение прекарщенно на координатах {1}", Name, Position.ToString()));
                    return;
                }
                else if (Map.GetTerainType(Position + 1) == TerainType.Mount)
                {
                    Loger.GetLoger().Write(string.Format("Юнит {0} не может летать, движение прекарщенно на координатах {1}", Name, Position.ToString()));
                    return;
                }
                Position += 1;
            }
            Loger.GetLoger().Write(string.Format("Юнит {0} пришел на координаты {1}", Name, coord));
        }

        public void Rearrange(int coord)
        {
            Position = coord;
        }

        public void MoveTo(string coord)
        {
            MoveTo(int.Parse(coord));
        }

        public IUnit Clone()
        {
            Loger.GetLoger().Write("Создана копия юнита");
            return new Unit(Map, Name) { Position = Position };
        }
    }
}

