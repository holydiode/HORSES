namespace HORSES
{
    interface IPlayerManager
    {
        public Player CurentPlayer { get;}

        public void EndTurn();

        public void AddPlayer(Player player); 
    }

}
