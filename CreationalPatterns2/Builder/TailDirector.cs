using HorsesComon;

namespace CreationalPatterns2
{
    public class TailDirector
    {
        private ITailBuilder _builder;
        private int _coord;
        private Map _map;
        public TailDirector(ITailBuilder builder, Map map, int coord)
        {
            _builder = builder;
            _coord = coord;
            _map = map;
        }

        public Tail GetTail()
        {
            _builder.BindMap(_map);
            _builder.SetTerainType(_coord);
            _builder.PutResourses(_coord);
            _builder.PlaceUnit(_coord);

            Loger.GetLoger().Write("Строитель закончил построение тайла {0}", _coord);
            return _builder.GetTail();
        }

    }

}
