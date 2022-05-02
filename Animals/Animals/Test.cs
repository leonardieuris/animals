using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Test
    {
        public void Farm()
        {
            var topo = new Topo();
            var gatto = new Gatto();
            var cane = new Cane();
            var carota = new Vegetale("Carota");

            var resultTopo = topo.Eat(carota);
            var resultGatto = gatto.Eat(topo);
            var resultCane = cane.Eat(carota);
            var result2Cane = cane.Eat(topo);
            ;



        }
    }
}
