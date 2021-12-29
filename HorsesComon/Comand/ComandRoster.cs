using System.Collections.Generic;

namespace HorsesComon
{
    public class ComandRoster
    {
        public IList<IComand> Comands { private set; get; }

        public ComandRoster(IList<IComand> comands)
        {
            Comands = comands;
        }

        public void Execute(int indexComand, int parametr)
        {
            Comands[indexComand].Execute(parametr);
        }

        public void Add(IComand comand)
        {
            Comands.Add(comand);
        }
    }

}
