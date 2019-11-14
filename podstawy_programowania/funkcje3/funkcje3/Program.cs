using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("Wartość zmiennej a przed wywołaniem funkcji: {0}",a);
            increment(ref a);
            Console.WriteLine("Wartość zmiennej a po wywołaniu funkcji: {0}", a);
            Console.ReadKey();
        }
        static void increment(int x)
        {
            x += 10;
            Console.WriteLine("zmienna x wewnątrz funkcji: {0}", x);
        }
    }
    
}
