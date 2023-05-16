using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrep
{
    internal class functionsAndParams
    {
        /*static void Main(string[] args)
        {
            double total = CheckOut(3.99, 5.75, 15);

            Console.WriteLine(total);

            int x;
            int y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);


            }
            catch (FormatException e)
            {

                Console.WriteLine("Enter only numbers please");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally {
                Console.WriteLine("Thanks for using the app");
            }

            Console.ReadKey();

        }*/

        static double CheckOut(params double[] prices) {


            double total = 0;

            foreach (double price in prices) {
                total += price;
            }

            return total;



        }
    }
}
