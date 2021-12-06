using System;
using System.Collections.Generic;
using System.Linq;
using HorsesComon;

namespace HorsesComon
{
    public class Player : IPlayer
    {
        public int ID { get; private set; }

        public List<IUnit> Units { get; protected set; }

        public Dictionary<string, int> Resourses { get; protected set;}

        public IUnitFactory UnitFactory { get;  protected set; }

        public bool IsInGame {protected set; get; }

        public Map Map{ get; protected set; }

        public Player(int ID, IUnitFactory unitFactory)
        {
            this.ID = ID;
            Units = new();
            UnitFactory = unitFactory;

            Resourses = new Dictionary<string, int>();
            InitResours();
        }

        public Player(int ID, Map map ,IUnitFactory unitFactory):this(ID, unitFactory)
        {
            Map = map;
        }

        private void InitResours()
        {
            Resourses.Add("золото", 0); 
            Resourses.Add("древесина", 0); 
            Resourses.Add("руда", 0); 
        }

        public void Lose()
        {
            Loger.GetLoger().Write("игрок " + ID.ToString() + " завершил игру");
            IsInGame = false;
        }

        public IPlayer Clone()
        {
            return new Player(ID)
            {
                Resourses = Resourses.ToDictionary(entry => entry.Key, entry => entry.Value),
                Units = Units.Select(item => item.Clone()).ToList(),
                UnitFactory = UnitFactory,
                IsInGame = IsInGame,
                Map = Map
            };
        }

        public IUnit ProductUnit(string unitName)
        { 
            switch (unitName) {
                case "archer":
                    return UnitFactory.GetArcher(Map, unitName, 3, 3);
                case "chilivary":
                    return UnitFactory.GetChilivary(Map, unitName, 4);
            };
            return null;
        }


        IUnit IPlayer.ProductUnit(string unitName)
        {
            throw new NotImplementedException();
        }

        public Player(int id)
        {
            this.ID = id;
            IsInGame = true;
            Resourses = new();
            Loger.GetLoger().Write("Игрок " + id.ToString() + " Создан");
        }


        public static bool operator ==(Player a, Player b)
        {
            return a.ID == b.ID;
        }

        public static bool operator !=(Player a, Player b)
        {
            return a.ID != b.ID;
        }

    }
}
