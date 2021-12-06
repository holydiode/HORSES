using HorsesComon;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CreationalPatterns
{
    class Program
    {
        static void SingtonTest()
        {
            Loger.GetLoger().Coment("Обратимся к мастеру игры");
            GameMaster mster = GameMaster.GetMaster();
            Loger.GetLoger().Coment("Обратимся к мастеру игры повторно, и есили он не проинициализируется, то паттерн реализован корректно");
        }

        static void FactoryMethodTest(){
            Loger.GetLoger().Coment("Создадим менеджер игроков по умолчанию");
            PlayerManager testPlayerManager = new ();
            Loger.GetLoger().Coment("Создадим игрока по умолчанию");
            testPlayerManager.CreatePlayer();
            IPlayer player = testPlayerManager.CurentPlayer;
            Loger.GetLoger().Coment("Получим юнита созданного игрока");
            player.ProductUnit("archer");
            Loger.GetLoger().Coment("Получим списко ресурсов игрока");
            Loger.GetLoger().Write(string.Join(" ", player.Resourses.Select(kvp => kvp.Key + ": " + kvp.Value.ToString())));


            Loger.GetLoger().Coment("Создадим пользовательский менеджер игроков");
            testPlayerManager = new HeroesPlayerManager();
            Loger.GetLoger().Coment("Создадим игрока используя тот же метод");
            testPlayerManager.CreatePlayer();
            player = testPlayerManager.CurentPlayer;
            Loger.GetLoger().Coment("Если созданный юнит и список ресурсов будет отличатся, значит паттерн реализован корректно");
            player.ProductUnit("archer");
            Loger.GetLoger().Write(string.Join(" ", player.Resourses.Select(kvp => kvp.Key + ": " + kvp.Value.ToString())));
        }

        static void PrototypeTest()
        {
            Map map = new(new List<TerainType>() { TerainType.Earth, TerainType.Mount, TerainType.Earth, TerainType.Water, TerainType.Earth});
            Loger.GetLoger().Coment("Создадим юнита и обернем его в несколько декораторов");
            IUnit unit = new FlyableUnit(new SwimableUnit(new Unit(map, "биплан")), 2);
            Loger.GetLoger().Coment("Получим копию юнита");
            IUnit copyUnit = unit.Clone();
            Loger.GetLoger().Coment("Переместим оригенальный юнит");
            unit.MoveTo(4);
            Loger.GetLoger().Coment("Переместим копию юнита на тоже положение, если он переместился, значит паттерн реализован корректно");
            copyUnit.MoveTo(4);
        }

        static void AbstractFactoryTest()
        {
            Loger.GetLoger().Coment("Создадим игрока с конкртной реализацией абстрактной фабрики");
            Player player = new(1, new CivilizationUnitFactory());
            Loger.GetLoger().Coment("Полуем объект созданный фабрикой, и протестируем его поведение");
            Loger.GetLoger().Write(string.Format("Юнит нанес {0} Урона", ((IArcher)player.ProductUnit("archer")).Shoot(20)));
            Loger.GetLoger().Coment("Создадим игрока с другой реализацией абстрактной фабрики");
            player = new(1, new HeroesUnitFactory());
            Loger.GetLoger().Coment("Полуем объект созданный новой фабрикой, и применем на него те же методы");
            Loger.GetLoger().Coment("Если поведение юнита изменилось, значит паттерн реализован корректно");
            Loger.GetLoger().Write(string.Format("Юнит нанес {0} Урона", ((IArcher)player.ProductUnit("archer")).Shoot(20)));
        }

        static void Main(string[] args)
        {
            SingtonTest();
            FactoryMethodTest();
            PrototypeTest();
            AbstractFactoryTest();
        }
    }
}
