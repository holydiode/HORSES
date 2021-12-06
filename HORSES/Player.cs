using System.Collections.Generic;

namespace HORSES
{
    public class Player
    {
        public int ID { private set; get; }

        public Player(int id)
        {
            this.ID = id;
            Loger.GetLoger().Write("Игрок " + id.ToString() + " Создан");
        }

        public static bool operator == (Player a, Player b)
        {
            return a.ID == b.ID;
        }

        public static bool operator != (Player a, Player b)
        {
            return a.ID != b.ID;
        }

    }


}