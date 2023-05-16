using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrep
{
     class Classes
    {

        static void Main(String[] args) {

            Messages.Hello();

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");

            Console.WriteLine(Car.numberOfCars);
        }
    }

    class Car {

        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }
    }
}
