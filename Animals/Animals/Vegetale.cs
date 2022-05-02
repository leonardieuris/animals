using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Vegetale : IVegetables
    {
        private readonly string Name;
        public Vegetale(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
