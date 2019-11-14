using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Show1());
            Show();
            
            Add(4, 8);
            Add(1, 2, 3);
            Console.WriteLine(Add(1,2,3,4));
            Console.WriteLine(Add(d: 3, a: 5));
            Console.ReadKey();
        }
        static void Show()
        {
            Console.WriteLine("WSB");
        }
        static int Show1()
        {
            return 0;
        }
        static void Add(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania {1} i {2}: {0}", result, a, b);

        }

        static void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("Wynik dodawania {1} i {2} i {3}: {0}",result,a,b,c);
        }
        static int Add(int a, int d,int b = 3, int c = 5)
        {

            return a + b + c + d;
        }

    }
}
