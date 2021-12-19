using System;
using System.Collections.Generic;
using HorsesComon;

namespace Structural_pattern
{
    class Program
    {
        private static void IteratorTest()
        {
            PlayerManager players = new();
            players.AddPlayer(new Player(1));
            players.AddPlayer(new Player(2));
            players.AddPlayer(new Player(3));

            Loger.GetLoger().Coment("обработаем список из игроков");

            foreach(Player currentPlayer in players)
            {
                Loger.GetLoger().Write("игрок " + currentPlayer.ID.ToString() + " обработан");
            }

            Loger.GetLoger().Coment("Выведем игрока из игры");

            players.CurentPlayer.Lose();
            Loger.GetLoger().Coment("снова обработаем список");

            foreach (Player currentPlayer in players)
            {
                Loger.GetLoger().Write("игрок " + currentPlayer.ID.ToString() + " обработан");
            }

        }

        private static void AdapterTest()
        {
            IUnit king = new ChessAdapter("Пешка", 'E', 2);
            king.MoveTo("E4");
        }

        private static void WraperTest()
        {
            Map map = new(new List<TerainType>() {
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Water,
                TerainType.Water,
                TerainType.Mount,
                TerainType.Mount,
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Water,
                TerainType.Earth
                }
            );
            Loger.GetLoger().Coment("Обычный объект юнита не обернутый в декораторы");
            IUnit testUnit = new Unit(map, "Ферзь");
            testUnit.MoveTo(10);
            Loger.GetLoger().Coment("Обернем юнита дав возможность плыть");
            testUnit = new SwimableUnit(testUnit);
            testUnit.MoveTo(10);
            Loger.GetLoger().Coment("Обернем юнита в дргуой декоратор дав возможность летать");
            testUnit = new FlyableUnit(testUnit, 3);
            testUnit.MoveTo(10);


            Loger.GetLoger().Coment("Проверим разницу между летающим юнитом и одновременно литающим и плавающим");
            testUnit = new FlyableUnit( new Unit (map, "биплан"), 6);
            testUnit.MoveTo(10);
            testUnit = new FlyableUnit( new SwimableUnit(new Unit(map, "гидросомалет")), 6);
            testUnit.MoveTo(10);
        }

        private static void CompositeTest()
        {
            Map map = new(new List<TerainType>() { TerainType.Earth, TerainType.Earth, TerainType.Earth, TerainType.Earth });
            Loger.GetLoger().Coment("Создадим управляемую группу из двух юнитов");
            IUnit avangarde = new ManagableGroup(new List<IUnit> { new Unit(map, "копейщик"), new Unit(map, "рыцарь") }, "авангард");
            avangarde.MoveTo(3);
            Loger.GetLoger().Coment("Создадим новую управляемую группу включив в неё предидущую и добавив еще один юнит");
            IUnit army = new ManagableGroup(new List<IUnit> { new Unit(map, "лучник"), avangarde}, "Армия");
            army.MoveTo(5);
        }

        static void Main(string[] args)
        {
            AdapterTest();
        }
    }
}
