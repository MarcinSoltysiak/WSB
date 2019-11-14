using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            increment(out a);
            Console.WriteLine("Wartość zmiennej a po wywołaniu funkcji: {0}", a);
         Console.ReadKey();
        }   
        static void increment(out int x)
        {
            x = 1;
            x += 10;
            Console.WriteLine("zmienna x wewnątrz funkcji: {0}", x);
        }
    }
    
}