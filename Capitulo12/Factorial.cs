using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo12
{
    public class Factorial
    {
        public static void Main(string[] args)
        {
            factorial(5);
        }

        public static void factorial(int r)
        {
            int f = 1;
            for (int i = 1; i <= r; i++)
            {
                f *= i;
                Console.WriteLine(f);
            }
            Console.WriteLine("El factorial de " + r + "es: " + f);
            Console.ReadKey();
        }
    }
}
