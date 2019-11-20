using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ćwiczenia_przed_kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4200000;
            Console.WriteLine("Wybierz program który chcesz uruchomić\n1 - funkcja\n2 - tablice\n3 - kalkulator\n4 - wciśnij X żeby wyjść");

            while (true)
            {
                for (int c = 0; c < a; c++)
                {
                    try
                    { 
                        int x = int.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 1:
                                Add(3, 5);

                                Console.ReadKey();
                                break;
                            case 2:
                                int n = 3;
                                string[] dni = new string[3] { "pierwszy", "drugi", "trzeci" };
                                string[] tab = new string[n];
                                for (int i = 0; i < tab.Length; i++)
                                {
                                    Console.WriteLine("Podaj " + dni[i] + " dzień tygodnia");
                                    tab[i] = Console.ReadLine();
                                }
                                for (int b = 0; b < 1; b++)
                                    foreach (string item in dni)
                                    {

                                        Console.WriteLine("Jako " + item + " dzień tygodnia wpisałeś ");
                                        foreach (string element in tab)
                                        {
                                            Console.WriteLine(element);
                                        }
                                    }
                                break;
                            case 3:
                                try
                                {
                                    Console.WriteLine("Które działanie chcesz wykonać?\n1 - dodawanie\n2 - odejmowanie\n3 - mnożenie\n4 - dzielenie");
                                    string x1 = Console.ReadLine();
                                    switch (x1)
                                    {
                                        case "1":
                                            Add1(2, 4);
                                            break;
                                        case "2":
                                            odejmowanie(2, 3);
                                            break;
                                        case "3":
                                            mnożenie(2, 3);
                                            break;
                                        case "4":
                                            dzielenie(3, 2);
                                            break;

                                    }
                                }
                                catch (SystemException)
                                {
                                    Console.WriteLine("Zły format");
                                }
                                break;
                            default:
                                break;


                        }
                        break;

                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("zły format");
                    }
                }
            }

            
        }
        
        static void Add(int a ,int b)
        {
            
            int suma = a + b;
            Console.WriteLine("wynikiem dodawania jest: {0}",suma);
        }
        static void Add1(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine(suma);
        }
        static void odejmowanie(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine(suma);
        }
        static void mnożenie(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine(suma);
        }
        static void dzielenie(double a, double b)
        {
            double suma = a + b;
            Console.WriteLine(suma);
        }

    }
}
