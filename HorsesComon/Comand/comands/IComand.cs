using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsesComon
{
    public interface IComand
    {
        public string Name { get; }
        public void Execute(int coords);
    }

}
