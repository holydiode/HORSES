using HorsesComon;
using System;
using System.Collections.Generic;

namespace BehaviorPattern2
{
    class Program
    {

        static void ComandTest() {
            Loger.GetLoger().Coment("последовательно создадим двух разных юнитов");
            Loger.GetLoger().Coment("затем вызовим их разные методы через одно и то же обращение");
            Loger.GetLoger().Coment("используя исполнитель команд");
            IMap map = new LineMap(new List<TerainType>() { TerainType.Earth, TerainType.Earth, TerainType.Earth });

            IUnit unit = new HeroesArcher(map, "лучник",11, 32, 5);
            Loger.GetLoger().Coment("получим списко команд который может выполнить юнит, и выполним вторую команду");
            Loger.GetLoger().Write(string.Join("\n", unit.Comands.Comands));
            unit.Comands.Execute(1, 20);
            Loger.GetLoger().Coment("проделаем то же самое со вторым юнитом");
            unit = new HeroesChiliavry(map, "воин", 5);
            Loger.GetLoger().Write(string.Join("\n", unit.Comands.Comands));
            unit.Comands.Execute(1, 20);
        }

        static void StrategyTest()
        {
            Loger.GetLoger().Coment("Моздадим двух одинаковых юнитов с разными стратегиями поиска пути");
            IMap map = new LineMap(new List<TerainType>() {
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Earth
            });
            IUnit unit = new Unit(map, "прямой юнит");
            unit.MoveTo(4);
            map = new LoopMap(new List<TerainType>() {
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Earth,
                TerainType.Earth
            });
            unit = new Unit(map , "цикличный юнит");
            unit.MoveTo(4);
        }

        static void VisitorTest()
        {
            Loger.GetLoger().Coment("Создадим список юнитов разных классов, которых будем посещать разными поситителями");
            IMap map = new LineMap(new List<TerainType>() { TerainType.Earth, TerainType.Earth, TerainType.Earth });
            List<IUnit> units = new List<IUnit>() { new Unit(map, "юнит"), new HeroesArcher(map, "юнит", 12, 3, 4), new HeroesChiliavry(map, "юнит", 18) };
            IUnitVisitor visiter = new CollectInfo();

            Loger.GetLoger().Coment("теперь соберем инормацию о них с помощью посетителя");

            foreach (IUnit curUnit in units)
            {
                Loger.GetLoger().Write( curUnit.AcceptVisitor(visiter));
            }

            Loger.GetLoger().Coment("Сновасоберем информцию, использую другоого посетителя");

            visiter = new CollectArmyPower();

            foreach (IUnit curUnit in units)
            {
                Loger.GetLoger().Write(curUnit.AcceptVisitor(visiter));
            }
        }

        static void Main(string[] args)
        {
            StrategyTest();
        }
    }
}
