using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Gatto : ICarnivour
    {
        public string Eat(IHerbivore animal)
        {
            return $"Ho mangiato {animal.GetName}";
        }
    }
}
