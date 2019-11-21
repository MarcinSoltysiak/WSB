using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("WSB - kolokwium nr 1,Marcin Sołtysiak");
                    Console.WriteLine("Podaj długość pierwszego boku prostokąta");
                    int boka = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj długość drugiego boku prostokąta");
                    int bokb = int.Parse(Console.ReadLine());
                    int pole = boka * bokb;
                    uint wiek;
                    try
                    {
                        Console.WriteLine("Podaj swój wiek:");
                        wiek = uint.Parse(Console.ReadLine());

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Podana wartość musi być dodatnia");
                    }
                    try
                    {
                        Console.WriteLine("Który program chcesz wybrać?\n1. Pole prostokąta\n2. wyświetl czy wiek jest liczbą parzystą\n3. macierz\n4. funkcja\n5. wyjdź");
                        int x = int.Parse(Console.ReadLine());
                        switch (x)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Bok A: {0}", boka);
                                Console.WriteLine("Bok B: {0}", bokb);
                                Console.WriteLine("Pole kwadratu wynosi: {0}", pole);
                                break;
                            case 2:
                                Console.WriteLine("Podaj swój wiek");
                                wiek = uint.Parse(Console.ReadLine());
                                if (wiek % 2 == 0)
                                {
                                    Console.WriteLine("wiek jest liczbą parzystą");
                                }
                                else
                                {
                                    Console.WriteLine("wiek nie jest liczbą parzystą");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Podaj stopień macierzy");
                                int n = int.Parse(Console.ReadLine());
                                int[] tab = new int[n * n];
                                for (int g = 0; g < tab.Length; g++)
                                {
                                    Console.WriteLine("Podaj elementy macierzy");
                                    tab[g] = int.Parse(Console.ReadLine());
                                }
                                for (int g1 = 0; g1 < tab.Length; g1++)
                                {
                                    Console.Write(tab[g1]);
                                    for (int g2 = 0; g2 < g1; g2++)
                                    {
                                        Console.Write("\n");
                                    }
                                }
                                int suma = tab.Sum();
                                Console.WriteLine("suma elementów macierzy wynosi: {0}", suma);

                                break;
                            case 4:
                                Add(1, 3);
                                break;
                            case 5:
                                Environment.Exit(0);
                                break;

                        }
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("musisz coś wpisać");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("cyfra musi mieścić się w przedziale od 0 do 4 250 304");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Podana wartość musi być cyfrą");
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Podałeś zły format");
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("musisz coś wpisać");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("cyfra musi mieścić się w przedziale od 0 do 4 250 304");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana wartość musi być cyfrą");
                }
                catch (SystemException)
                {
                    Console.WriteLine("Podałeś zły format");
                }




            }
            
            

        }
        static void Add(int a, int b)
        {
            try
            {
                Console.WriteLine("Podaj ilość członków rodziny");
                uint c = uint.Parse(Console.ReadLine());

                uint[] wiek = new uint[c];
                for (uint c1 = 0; c1 < wiek.Length; c1++)
                {
                    Console.WriteLine("Podaj wiek członka rodziny");
                    wiek[c1] = uint.Parse(Console.ReadLine());
                }

                string[] imie = new string[c];
                for (uint c2 = 0; c2 < wiek.Length; c2++)
                {
                    Console.WriteLine("Podaj imię członka rodziny");
                    imie[c2] = Console.ReadLine();
                }
                for (uint c3 = 0; c3 < wiek.Length; c3++)
                {
                    Console.WriteLine(imie[c3] + " ma " + wiek[c3]);
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("musisz coś wpisać");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("cyfra musi mieścić się w przedziale od 0 do 4 250 304");
            }
            catch (FormatException)
            {
                Console.WriteLine("Podana wartość musi być cyfrą");
            }
            catch (SystemException)
            {
                Console.WriteLine("Podałeś zły format");
            }
            
            
            
            
        }
    }
}
