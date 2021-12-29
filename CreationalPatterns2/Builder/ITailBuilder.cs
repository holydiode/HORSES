namespace CreationalPatterns2
{
    public interface ITailBuilder
    {
        public void BindMap(Map map);
        public void SetTerainType(int terainSeed);
        public void PutResourses(int resourseSeed);
        public void PlaceUnit(int unitSeed);
        Tail GetTail();
    }

}
