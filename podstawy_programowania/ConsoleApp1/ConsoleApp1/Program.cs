using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //typ wartościowy
            int a = 10;
            int b = a;

            a--;
            b++;
            Console.WriteLine("zmienna a: {0}", a); //9
            Console.WriteLine("zmienna b: {0}", b); //11

            //typ referecyjny
            int[] tabA = { 2, 2, 2 };
            int[] tabB = tabA;
            tabA[2] = 10;
            tabB[0] = 8;

            foreach (int item in tabA )
            {
                Console.Write("{0}",item);
            }
            foreach (int item in tabB)
            {
                Console.Write("{0}", item);
            }
            //kopiowanie tablic 1 sposób

            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[5];

            foreach (int item in tabCopy)
            {
                Console.Write("{0}", item);
            }

            tab.CopyTo(tabCopy, 0);

            foreach (int item in tabCopy)
            {
                Console.WriteLine("\n{0}", item);
            }

            //kopiowanie tablic 2 sposób

            Array.Copy(tab, tabCopy, 5);

            foreach (int item in tabCopy)
            {
                Console.WriteLine("\n{0}", item);
            }

            Console.ReadKey();
        }
    }
}
