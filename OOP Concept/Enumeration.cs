using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Enumeration
    {
        public static void main(string[] args)
        {
            Console.WriteLine(Week.Monday); // Monday
            Console.WriteLine((int)Week.Tuesday); // 1
            Console.WriteLine((Week)4); // Friday
        }
    }
}
