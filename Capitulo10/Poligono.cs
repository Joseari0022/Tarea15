using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10
{
    public class Poligono
    {
        public Double Pot { get; set; }
        public Poligono()
        {

        }

        public Poligono(Double perimetro, Double pot)
        {
            Perimetro = perimetro;
            Pot = pot;
        }
    }
}
