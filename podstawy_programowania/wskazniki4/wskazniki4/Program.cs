using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki4
{
    class Program
    {
        struct test
        {
            public int n;
        }


            unsafe static void Main(string[] args)
            {
                test x = new test();
                test* p = &x;
            //p->n = 20;
            p->n = 20;
            (*p).n = 20;




            Console.WriteLine(x.n);
            Console.ReadKey();
            }
        
    }
}
