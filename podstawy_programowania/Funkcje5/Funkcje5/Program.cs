using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;
            Console.WriteLine("Wartości tablicy przed wywoałaniem funkcji: {0} {1}", tab[0], tab[1]);
            Tab1(tab);
            ShowTable(tab);
            Console.ReadKey();
        }
        static void Tab1(int[] tab)
        {
            tab[0] = 50;
            tab[1] = 100;
            Console.WriteLine("Wartości tablicy wewnątrz funkcji: {0} {1}", tab[0], tab[1]);
        }
        static void ShowTable(int[] tab)
        {
            Console.WriteLine("Zawartość tablicy");
            foreach (int item in tab)
            {
                Console.WriteLine("{0}",tab);
            }
        }
    }
}
