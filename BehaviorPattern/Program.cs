using HorsesComon;
using System;

namespace BehaviorPattern
{
    class Program
    {
        static void ObseverTest()
        {
            Loger.GetLoger().Coment("Создадим объект наблюдателя");
            IPlayer player = new PlayerWithResourseIncome(1, 3);
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
            State.Unit unit = new("патрульный");
            Loger.GetLoger().Coment("Активируем десйствие, управляймое состоянием");
            unit.SeeAnamy();
            Loger.GetLoger().Coment("Сменим состояния юнита и повторим действие");
            unit.SeeAnamy();
        }


        static void Main(string[] args)
        {
            ObseverTest();
        }
    }
}
