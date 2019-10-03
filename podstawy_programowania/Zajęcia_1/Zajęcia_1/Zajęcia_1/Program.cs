using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajęcia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz//

            /*234
             * 234234
             * 234*/
            Console.WriteLine("Janusz");


            //Zmienne i typy danych//
            int x = 5;
            Console.WriteLine(x);

            int x1 = 2, y = 10, z = 15;
            Console.Write("Zmienna x1 wynosi: ");
            Console.WriteLine(x1);

            //konkatenacja
            // \n tekst po tym w nowej lini
            Console.WriteLine("y = " + y + "\nz = " + z);

            int a = 10;
            int b = a;
            b = 15;
            Console.WriteLine(a + " " + b);

            //alternatywny sposób deklaracji zmiennej
            //int c = 0;

            int c = new int(); //wartość domyślna ==> null (brak referencji)

            Console.WriteLine(c);

            Console.WriteLine("Podaj swoje imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Twoje imię podane z klawiatury" + name);
            int z1 = 5;
            uint z2 = 34;

            //float

            float y1 = 51.23f;


            //double

            double y2 = 10.95;

            // oblicz pole kwadratu, dane użytkownik podaje z klawiatury

            Console.WriteLine("Podaj długość krótszego boku");
            double db = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość dłuższego boku");
            double dk = double.Parse(Console.ReadLine());
            double suma = dk * db;
            Console.WriteLine("Pole prostokąta wynosi: " + suma);

            db *= dk;

            Console.WriteLine(db);























            Console.ReadKey();
        }
    }
}
