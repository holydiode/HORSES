using HorsesComon;
using System;
using System.Collections.Generic;

namespace BehaviorPattern
{
    class Program
    {
        static void ObseverTest()
        {
            Loger.GetLoger().Coment("Создадим объект наблюдателя");
            Dictionary<string, int> resIn = new();
            resIn.Add("золото", 10);
            IPlayer player = new PlayerWithResourseIncome(1, resIn);
            GameMaster.GetMaster().AddPlayer(player);
            Loger.GetLoger().Coment("Подпишем объект");
            GameMaster.GetMaster().SubscribeEndBehaivor((IHaveTurnBehavior)player);
            Loger.GetLoger().Coment("Пропустим несколько ходов объект");
            GameMaster.GetMaster().EndTurn();
            GameMaster.GetMaster().EndTurn();
            Loger.GetLoger().Coment("Отпишем объек, и снова пропустим несколько ходов");
            GameMaster.GetMaster().UnsubscribeEndBehaivor((IHaveTurnBehavior)player);
            GameMaster.GetMaster().EndTurn();
            GameMaster.GetMaster().EndTurn();
        }

        static void StateTest()
        {
            Loger.GetLoger().Coment("Создадим объект имеющий состояния");
            State.Unit unit = new(new Map(new List<TerainType>() {TerainType.Earth, TerainType.Earth, TerainType.Earth}),"патрульный");
            Loger.GetLoger().Coment("Активируем десйствие, управляймое состоянием");
            unit.SeeEnamy(3);
            Loger.GetLoger().Coment("Сменим состояния юнита и повторим действие");
            unit.State = new State.AttackUnitState(unit);
            unit.SeeEnamy(3);
        }

        static void MementoTest()
        {
            Loger.GetLoger().Coment("Создадим менеджер снимков");
            SnapshotManager snapshots = new();
            Loger.GetLoger().Coment("Сделаем начальный снимок");
            snapshots.MakeSnapshot();

            Loger.GetLoger().Coment("Добавим в игру игрока с постоянным приростом рисурсов и сделаем снимок");
            Dictionary<string, int> resIn = new();
            resIn.Add("золото", 10);
            IPlayer player = new PlayerWithResourseIncome(1, resIn);
            GameMaster.GetMaster().AddPlayer(player);
            GameMaster.GetMaster().SubscribeEndBehaivor((IHaveTurnBehavior)player);
            snapshots.MakeSnapshot();
            Loger.GetLoger().Coment("Пропустим несколько ходов и сделаем новый снимок");
            GameMaster.GetMaster().EndTurn();
            GameMaster.GetMaster().EndTurn();
            snapshots.MakeSnapshot();
            Loger.GetLoger().Coment("Выведим игрока из игры и проверим её состояние");
            GameMaster.GetMaster().CurentPlayer.Lose();

            Loger.GetLoger().Write("Игрок продолжает играть:" + GameMaster.GetMaster().CurentPlayer.IsInGame.ToString());
            Loger.GetLoger().Write("Золото игрока:" + GameMaster.GetMaster().CurentPlayer.Resourses["золото"]);
            Loger.GetLoger().Coment("Постепенно будем откатываит изменения ");
            snapshots.LoadUndo();

            Loger.GetLoger().Write("Игрок продолжает играть:" + GameMaster.GetMaster().CurentPlayer.IsInGame.ToString());
            Loger.GetLoger().Write("Золото игрока:" + GameMaster.GetMaster().CurentPlayer.Resourses["золото"]);

            snapshots.LoadUndo();
            Loger.GetLoger().Write("Игрок продолжает играть:" + GameMaster.GetMaster().CurentPlayer.IsInGame.ToString());
            Loger.GetLoger().Write("Золото игрока:" + GameMaster.GetMaster().CurentPlayer.Resourses["золото"]);

        }

        static void Main(string[] args)
        {
            MementoTest();
            ObseverTest();
            StateTest();
        }
    }
}
