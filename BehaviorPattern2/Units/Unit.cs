using HorsesComon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern2
{
    public class Unit : IUnit
    {
        public string Name { private set;  get; }

        public IMap Map { private set;  get; }

        protected IPathFinder _pathFinder;

        public int Position { private set;  get; }

        public ComandRoster Comands { private set; get; }

        public Unit(IMap map, string name)
        {
            Name = name;
            Map = map;
            Position = 0;
            Comands = new ComandRoster(new List<IComand>() { new MoveComand(this) });
            _pathFinder = map.PathFinder;
        }

        public void MoveTo(int coord)
        {
            while(Position != coord)
            {
                if (Map.GetTerainType(_pathFinder.FindPath(Position, coord, Map)) == TerainType.Water)
                {
                    Loger.GetLoger().Write(string.Format("Юнит {0} не может плыть, движение прекарщенно на координатах {1}", Name, Position.ToString()));
                    return;
                } else if (Map.GetTerainType(_pathFinder.FindPath(Position, coord, Map)) == TerainType.Mount){
                    Loger.GetLoger().Write(string.Format("Юнит {0} не может летать, движение прекарщенно на координатах {1}", Name, Position.ToString()));
                    return;
                }
                Position = _pathFinder.FindPath(Position, coord, Map);
                Loger.GetLoger().Write(string.Format("Юнит {0} переместился на клетку {1}", Name, Position.ToString()));
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
            return new Unit(Map, Name) {Position = Position};
        }

        public virtual string AcceptVisitor(IUnitVisitor visitor)
        {
            return visitor.VisitUnit(this);
        }
    }
}
