using System;
//use of getter and setter
namespace Basics
{
    class Student
    {

        private string n;
        public int roll {  get; set; } //short hand
        public string Name
        {
            get
            {
                return n;
            }

            set
            {
                n = value;
            }
        }

        public void display()
        {
            Console.WriteLine(this.n);
        }
    }

    class Properties1
    {
        public static void main(string[] args)
        {
            Student s = new Student();
            s.Name = "Abhiraj";
            s.display(); //Abhiraj
            Console.WriteLine(s.Name);//Abhiraj
        }
    }
}
