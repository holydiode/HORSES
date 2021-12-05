using HorsesComon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public class Unit : IUnit
    {
        private Map _map;
        private string _name;
        private int _position;

        public string Name => _name;

        public Map Map => _map;

        public int Position => _position;

        public Unit(Map map, string name)
        {
            _name = name;
            _map = map;
            _position = 0;
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
                _position += 1;
            }
            Loger.GetLoger().Write(string.Format("Юнит {0} пришел на координаты {1}", Name, coord));
        }

        public void Rearrange(int coord)
        {
            _position = coord;
        }

        public void MoveTo(string coord)
        {
            MoveTo(int.Parse(coord));
        }

        public IUnit Clone()
        {
            Loger.GetLoger().Write("Создана копия юнита");
            return new Unit(Map, Name) {_position = Position};
        }
    }
}
