
namespace Animals
{
    public interface ICarnivour : IAnimal
    {
        string Eat(IHerbivore animal);
    }
}
