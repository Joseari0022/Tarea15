using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo10
{
    public class PoligonoString
    {
        public Double Pot { get; set; }
        public Double Perimetro { get; set; }
        public PoligonoString()
        {

        }

        public PoligonoString(Double perimetro, Double pot)
        {
            this.Perimetro = perimetro;
            this.Pot = pot;
        }

        public double Area
        {
            get { return Perimetro * Pot / 2; }
            set { Perimetro = 12; Pot = 3.25; }
        }

        public static void Main()
        {
            PoligonoString p = new PoligonoString();
            Console.WriteLine(p.ToString());
        }
    }
}
