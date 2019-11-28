using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskaźniki
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            char* x;
            char letter = 'x';
            x = &letter;
            Console.WriteLine("znak: {0}", letter);
            letter = 'a';

            Console.WriteLine("znak: {0}",letter);
            Console.WriteLine("znak: {0}",*x);
            Console.WriteLine("adres pamięcie zmiennej letter: {0:x}", (int)x);

            //Console.WriteLine("adres pamięcie zmiennej letter: {0:x}", (int)x); - system szesnastkowy

            int test = 123;
            Console.WriteLine(Convert.ToString(test,2));

            //konwertowanie na dowolny system

            double number;
            double* numberAddress;

            number = 10;
            numberAddress = &number;

            Console.WriteLine("Liczba wynosi: {0}", number);
            Console.WriteLine("Liczba wynosi: {0}",numberAddress->ToString());

            //->ToString() - inna wersja uzycia "*" przed zmienną

            Console.WriteLine("Adres pamięci zmiennej numberAddress: {0}",(int)numberAddress);

            Console.ReadKey();

        }
    }
}
