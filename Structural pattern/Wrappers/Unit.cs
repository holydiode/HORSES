using HorsesComon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_pattern
{


    public class Unit : IUnit
    {

        public string Name { get; private set; }

        public Map Map { get; private set; }

        public int Position { get; private set; }

        public Unit(Map map, string name)
        {
            Name = name;
            Map = map;
            Position = 0;
        }

        public void MoveTo(int coord)
        {
            while(Position != coord)
            {
                if (Map.GetTerainType(Position + 1) == TerainType.Water)
                {
                    Loger.GetLoger().Write(string.Format("Юнит {0} не может плыть, движение прекарщенно на координатах {1}", Name, Position.ToString()));
                    return;
                } else if (Map.GetTerainType(Position + 1) == TerainType.Mount){
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
    }
}
