using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorsesComon;

namespace Chess
{
    public class ChessFigure
    {
        protected char _letter;
        protected int _number;
        protected string _name;

        public ChessFigure(string name,char letter, int number)
        {
            _name = name;
            _letter = letter;
            _number = number;
        }

        public void Move(char letter, int number)
        {
            Loger.GetLoger().Write(_name + " " + _letter + _number + " перемещенна на клетку " + letter + number);

            _letter = letter;
            _number = number;
        }

    }
}
