using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrep
{
    internal class MathStuff
    {
        static void Main(String[] args) {
            double x = 3;

            double a = Math.Pow(x, 2);

            double b = Math.Sqrt(a);

            double c = Math.Abs(-9);

            double d = Math.Round(3.4);  // rounds normally
            double e = Math.Floor(3.99); // rounds down
            double f = Math.Ceiling(3.99); // rounds up



            Console.WriteLine(a + " , " + b + " , " + c);
            Console.WriteLine(d + " , " + e + " , " + f);

            double h = Math.Max(d, e);

            Console.WriteLine(h);





            Console.ReadKey();
        }
    }
}
