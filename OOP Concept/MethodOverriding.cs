using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Human
    {
        public virtual void hello()
        {
            Console.WriteLine("Hello..Human!!");
        }
    }

    public class Ram:Human
    {
        public override void hello()
        {
            Console.WriteLine("Hello..Ram!!");
        }
    }
    class MethodOverriding
    {
        public static void main(string[] args)
        {
            Human h = new Human();
            h.hello();
            Ram r = new Ram();
            r.hello();

            //Hello..Human!!
            //Hello..Ram!!
        }
    }
}
