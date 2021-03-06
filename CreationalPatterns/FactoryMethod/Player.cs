using System;
using System.Collections.Generic;
using System.Linq;
using HorsesComon;

namespace CreationalPatterns
{
    public class Player : IPlayer
    {
        public IUnitFactory UnitFactory { get; protected set; }
        public Map Map{ get; protected set; }

        public bool IsInGame { protected set; get; }

        public Player(int ID, IUnitFactory unitFactory, Map map = null)
        {
            this.ID = ID;
            Units = new();
            UnitFactory = unitFactory;
            Map = map;

            Resourses = new Dictionary<string, int>();
            InitResours();
        }

        private void InitResours()
        {
            Resourses.Add("золото", 0); 
            Resourses.Add("древесина", 0); 
            Resourses.Add("руда", 0); 
        }

        public int ID { get; private set; }

        public List<IUnit> Units { get; protected set; }

        public Dictionary<string, int> Resourses { get; protected set;}

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
                Units = Units.Select(item => item.Clone()).ToList()
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

        IPlayer IPlayer.Clone()
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
