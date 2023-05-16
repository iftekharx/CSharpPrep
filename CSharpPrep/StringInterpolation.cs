using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrep
{
    internal class StringInterpolation
    {
        static void Main(String[] args) {

            String fName = "Bob";
            String lName = "Roberts";

            int age = 21;

            Console.WriteLine($"Hello {fName}!");
            Console.WriteLine($"You are {age, 10} years old!");
            Console.WriteLine($"You are {age,-10} years old!");

        }
    }
}
