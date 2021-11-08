using System;

namespace HORSES
{
    class Program
    {
        static void TestProxy()
        {
            Loger.GetLoger().Coment("Инициализируем объекты");
            Player player1 = new Player(1);
            Player player2 = new Player(2);
            GameMaster.GetMaster().AddPlayer(player1);
            GameMaster.GetMaster().AddPlayer(player2);
            IUnit ladia = new Unit(player1, "ладья");
            IUnit king = new Unit(player2, "король");


            Loger.GetLoger().Coment("Вызываем метод без прокси");
            ladia.Move("E2E4");
            king.Move("E1E2");

            Loger.GetLoger().Coment("Вызываем метод через прокси");
            ladia = new SaveUnit(ladia as Unit);
            king = new SaveUnit(king as Unit);

            ladia.Move("E2E4");
            king.Move("E1E2");
            GameMaster.GetMaster().EndTurn();
            ladia.Move("E2E4");
            king.Move("E1E2");
        }


        static void Main(string[] args)
        {

            TestProxy();
        }
    }
}
