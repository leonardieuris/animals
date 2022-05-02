using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cane : IOnivorous
    {
        public string Eat(IFood food)
        {
            return $"Ho mangiato {food.GetName}";
        }
    }
}
