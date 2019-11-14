using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkEven(6));
            Console.WriteLine(dodawanie(1234));
            Console.ReadKey();
            
            //napisz program czy liczba jest parzysta lub nieparzysta
        }
        static string checkEven(int a)
        {
            if (a % 2 == 0)
            {
                
                return "Liczba jest parzysta";
            }
            else
            {

                return "Liczba jest nieparzysta";
            }
            
        }
        //napisz funkcję których wyświetli sumę cyfr w liczbie
        static int dodawanie(int a, int suma = 0)
        {
            do
            {
                suma = suma + a % 10;
                a /= 10;
            } while (a != 0);
            return suma;
        }
    }
}
