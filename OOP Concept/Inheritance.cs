using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class A
    {
        public int id;
        public A()
        {
            this.id = -1;
        }
        public A(int id)
        {
            this.id=id;
        }
    }

    class B : A
    {
        public string name;

        public B():base()
        {
            this.name = string.Empty;
        }

        public B(int id, string name) : base(id)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(this.id);
           Console.WriteLine(this.name);
        }
    }
    class Inheritance
    {
        public static void main(string[] args)
        {
            B b = new B(1, "Abhiraj");
            b.display();

            //1
            //Abhiraj
        }
    }
}
