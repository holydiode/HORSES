using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPattern2
{

    public interface IUnitVisitor
    {
        public string VisitUnit(IUnit unit);
        public string VisitArcher(IArcher unit);
        public string VisitСhilivary(IChilivary unit);

    }
}
