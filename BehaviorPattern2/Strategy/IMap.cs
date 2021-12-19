using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern2
{
    public interface IMap
    {
        public int Size{get;}

        public TerainType GetTerainType(int coord);

        public IPathFinder PathFinder { get; }

    }

}
