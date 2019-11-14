using System;
using Secondname;

using Outer.Middle.Inner;

namespace @namespace
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Firstname.name_1 ob1 = new Firstname.name_1();
            ob1.Show();
            name_1 ob2 = new name_1();
            ob2.Show();

            Prog ob = new Prog();
            Console.WriteLine(ob.Add(3,5));

            Console.ReadLine();
            
        }
    }
}

namespace Firstname
{
    class name_1
    {
        public void Show()
        {
            Console.WriteLine("Pierwszwa przestrzeń nazw");
        }
    }
}
namespace Secondname
{
    class name_1
    {
        public void Show()
        {
            Console.WriteLine("druga przestrzeń nazw");
        }
    }
}

namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Prog
            {
                public int x, y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }
        }
    }
}

