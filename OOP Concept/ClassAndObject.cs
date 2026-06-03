using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Car
    {
        public int id;
        public string name;

        public Car()
        {
            this.id = 0;
            this.name = "demo";
        }

        public Car(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Name: " + this.name);
        }
    }

    class ClassAndObject
    {
        public static void main(string[] args)
        {
            Car car = new Car(1, "Ford");
            car.display();
        }
    }
}
