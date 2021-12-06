using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess;
using HorsesComon;

namespace Structural_pattern
{
    public class ChessAdapter : ChessFigure, IUnit
    {
        public string Name => _name;

        public Map Map => null;

        public int Position => _number;

        public ChessAdapter(string name, char letter, int number) : base(name, letter, number) { }

        public void MoveTo(string coord)
        {
            Loger.GetLoger().Write("перемещение фигруы " + Name + " на координаты " + coord);
            base.Move(coord[0], int.Parse(coord[1].ToString()));
        }

        public void MoveTo(int coord)
        {
            throw new NotImplementedException();
        }

        public void Rearrange(int coord)
        {
            throw new NotImplementedException();
        }
    }

}
