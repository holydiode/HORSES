using System.Collections.Generic;
using HorsesComon;


namespace Structural_pattern
{
    public class Player
    {
        public int ID { private set; get; }

        public bool IsInGame { private set; get; }

        public void Lose() {
            Loger.GetLoger().Write("игрок " + ID.ToString() + " завершил игру");
            IsInGame = false;
        }

        public Player(int id)
        {
            this.ID = id;
            IsInGame = true;
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