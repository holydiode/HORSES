using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns2
{
    public enum TerainType
    {
        Earth,
        Water,
        Mount
    }

    public class Tail
    {
        public TerainType TerainType { get; set; }

        public Map Map { get; set; }

        public int Coord { get; private set; }

        public Tail(int coord)
        {
            Coord = coord;
        }

        private Dictionary<string, int> _resourses;
        public Dictionary<string, int> Resourses
        {
            get
            {
                if (_resourses == null)
                {
                    LoadAfterInit();
                    Loger.GetLoger().Write("");
                }
                return _resourses;
            }
            set
            {
                _resourses = value;
            }
        }
        public IList<IUnit> _units;
        public IList<IUnit> Units 
        { 
            get 
            {
                if (_units == null)
                {
                    LoadAfterInit();
                }
                return _units; 
            }
            set 
            {
                _units = value;
            }
        }

        public int Level { get; private set; }

        private void LoadAfterInit()
        {
            Rewrite(this.Map.LoadTile(this.Coord));
            Loger.GetLoger().Write("Тайл с координатами {0} полноценно инициализрован", Coord);
        }

        public void Rewrite(Tail tail)
        {
            TerainType = tail.TerainType;
            Map = tail.Map;
            Coord = tail.Coord;
            Resourses = tail.Resourses;
            Units = tail.Units;
            Level = tail.Level;
        }

    }
}
