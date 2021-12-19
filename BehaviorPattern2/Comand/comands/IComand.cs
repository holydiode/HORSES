using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern2
{
    public interface IComand
    {
        public string Name { get; }
        public void Execute(int coords);
    }

}
