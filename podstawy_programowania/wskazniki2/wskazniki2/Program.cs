using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki2
{
    class Program
    {
        unsafe static void Swap(int* a, int* b)
        {
            //korzystając ze wskanzików zamienić dwie zmienne
            int pom = *a;
            *a = *b;
            *b = pom;

        }
        unsafe static void Main(string[] args)
        {
            int x = 2;
            int y = 5;
            Console.WriteLine("wartości przed zamianą " + x + " " + y);
            Swap(&x, &y);
            Console.WriteLine("wartości przed zamianą " + x + " " + y);

            int a = 100;
            int b = 200;

            int* a1 = &a;
            int* b1 = &b;
            Console.WriteLine("wartość przed zamiana " + a + " " + b);
            Swap(a1, b1);
            Console.WriteLine("wartość po zamiana " + a + " " + b);









            Console.ReadKey();
        }
    }
}
