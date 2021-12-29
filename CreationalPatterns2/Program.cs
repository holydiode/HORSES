using HorsesComon;
using System;
using System.Linq;

namespace CreationalPatterns2
{
    class Program
    {
        public static void MultitonTest()
        {
            Loger.GetLoger().Coment("Протестируем инициализацию мультитона, аналогично инициализации синглтона");
            Loger.GetLoger().Coment("Попробуем дважды обратится к объекту мультитона по одному и тому же имени");
            Map.GetMap("Тактика");
            Map.GetMap("Тактика");
            Loger.GetLoger().Coment("Если объект инициализировался дважды, значет паттерн рализован ошибочно");
            Loger.GetLoger().Coment("Сделаем тоже самое с другим именем");
            Map.GetMap("Стратегия");
            Map.GetMap("Стратегия");
            Loger.GetLoger().Coment("Если объект инициализировался дважды или не проинициализировался, значет паттерн рализован ошибочно");
        }

        public static void TestBuilder()
        {
            Loger.GetLoger().Coment("Пртестируем работу паттерна создав объект с помощью билдера, сначало с псоледовательным вызовом команд");
            Loger.GetLoger().Coment("Создадим объект с помощью билдера, не будем приминять никаких методов и посмотрим на список ресурсов");
            RandomTailBuilder builder = new(13);
            Tail player = builder.GetTail();
            Loger.GetLoger().Write(string.Join(" ", player.Resourses.Select(kvp => kvp.Key + ": " + kvp.Value.ToString())));
            Loger.GetLoger().Coment("Теперь дополним объект, вызвав метод строителя, и снова посмотрим список");
            builder.PutResourses(13);
            Loger.GetLoger().Write(string.Join(" ", player.Resourses.Select(kvp => kvp.Key + ": " + kvp.Value.ToString())));
            Loger.GetLoger().Coment("Сделаем тоже самое используя директора");
            TailDirector director = new(new RandomTailBuilder(13), Map.GetMap(), 13);
            Loger.GetLoger().Write(string.Join(" ", player.Resourses.Select(kvp => kvp.Key + ": " + kvp.Value.ToString())));
        }

        public static void TastLazy()
        {
            Loger.GetLoger().Coment("Получим объект с линивой рализацией");
            Tail tile = Map.GetMap().GetTile(12);
            Loger.GetLoger().Coment("Теперь обратимся к полю, которое должно инициализироваться с запаздыванием");
            Loger.GetLoger().Write(string.Join(" ", tile.Resourses.Select(kvp => kvp.Key + ": " + kvp.Value.ToString())));
        }

        public static void TastPool()
        {
            Loger.GetLoger().Coment("Дважды обртимя к объекту оъекту");
            Tail tile = Map.GetMap().GetTile(12);
            tile = Map.GetMap().GetTile(12);
            Loger.GetLoger().Coment("Если строитель работал дважды, значит паттерн реализован не верно");

        }

        static void Main(string[] args)
        {
            TastPool();
        }
    }
}
