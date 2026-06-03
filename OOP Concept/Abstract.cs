using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public abstract class Animal
    {
        public abstract void sounds();
    } 

    public class Dog : Animal
    {
        public override void sounds()
        {
            Console.WriteLine("Bark.. Bark!!");
        }
    }
    class Abstract
    {
        public static void main(string[] args)
        {
            //Animal a = new Animal(); // Error
            Animal a = new Dog();
            a.sounds();
        }
    }
}
