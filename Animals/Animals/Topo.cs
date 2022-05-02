namespace Animals
{
    public class Topo : IHerbivore
    {
        public string Eat(IVegetables vegetables)
        {
            return $"Ho mangiato {vegetables.GetName}";
        }

        public string GetName()
        {
            return "Topo";
        }
    }
}
