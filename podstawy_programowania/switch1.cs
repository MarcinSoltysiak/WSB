using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - pole kwadratu \n2 - pole koła");
            int x = int.Parse(Console.ReadLine());
            switch (x) {

                case 1:
                    Console.Clear();
                    Console.WriteLine("podaj bok kwadratu");
                    string a = Console.ReadLine();
                    int a1;
                    if (int.TryParse(a, out a1))
                    {
                        int pole = a1 * a1;
                        Console.WriteLine("Pole kwadratu wynosi: {0}",pole );
                    }
                    else
                    {
                        Console.WriteLine("podana wartość musi być cyfrą");
                    }

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("podaj promień koła");
                    string r = Console.ReadLine();
                    double r1;
                    
                    if (double.TryParse(r, out r1))
                    {
                        double pk = r1 * r1 * Math.PI;
                        Console.WriteLine("pole koła wynosi: {0}", pk);
                    }
                    else
                    {
                        Console.WriteLine("podana wartość musi być cyfrą");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
