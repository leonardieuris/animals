using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface IHerbivore : IFood, IAnimal
    {
        string Eat(IVegetables vegetables);

    }
}
