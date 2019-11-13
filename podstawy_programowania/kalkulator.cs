using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjątki3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = 10;
            try
            {
                Console.WriteLine("Podaj dzień tygodnia (1-5)");
                string str = Console.ReadLine();
                x = uint.Parse(str);
            }
            catch
            {
                Console.WriteLine("error");
            }
            finally
            {
                Console.WriteLine("x = {0}", x);
            }
            //####################################################
            switch (x)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    throw new System.Exception("masz już weekend");
                    break;
                case 7:
                    throw new System.Exception("masz już weekend");
                    break;

                default:
                    throw new System.ArgumentOutOfRangeException("błędy zakres");

                    break;
            }

            //napisz kalkulator uwzględnij wyjątki 
            //dodaj menu wyboru działania 
            //użytkownik może zamknąć program wpisując XD
            Console.WriteLine("Wciśnij: \n1 - żeby dodawać\n2 - żeby odejmować\n3 - żeby mnożyć\n4 - żeby dzielić");
            string c = Console.ReadLine();
            int c1;
            c1 = int.Parse(c);
            int z;
            int z1;
            int n;
            int n1;
            int b;
            int b1;
            double z2;
            double z3;


            switch (c)
            {
                case "1":


                    while (true)
                    {
                        Console.WriteLine("Podaj wartość a: ");
                        try
                        {
                            string a2 = Console.ReadLine();
                            z = int.Parse(a2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Podaj wartość b: ");
                        try
                        {
                            string b2 = Console.ReadLine();
                            z1 = int.Parse(b2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }


                    }

                    int suma = z + z1;
                    Console.WriteLine("suma wynosi: {0}", suma);
                    break;

                case "2":

                    while (true)
                    {
                        Console.WriteLine("Podaj wartość a: ");
                        try
                        {
                            string a2 = Console.ReadLine();
                            n = int.Parse(a2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Podaj wartość b: ");
                        try
                        {
                            string b2 = Console.ReadLine();
                            n1 = int.Parse(b2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }

                    }
                    int różnica = n - n1;
                    Console.WriteLine("suma wynosi: {0}", różnica);
                    break;
                case "3":
                    while (true)
                    {
                        Console.WriteLine("Podaj wartość a: ");
                        try
                        {
                            string a2 = Console.ReadLine();
                            b = int.Parse(a2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Podaj wartość b: ");
                        try
                        {
                            string b2 = Console.ReadLine();
                            b1 = int.Parse(b2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }

                    }
                    int mnożenie = b * b1;
                    Console.WriteLine("iloczyn wynosi: {0}", mnożenie);
                    break;
                case "4":

                    while (true)
                    {
                        Console.WriteLine("Podaj wartość a: ");
                        try
                        {
                            string a2 = Console.ReadLine();
                            z2 = double.Parse(a2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Podaj wartość b: ");
                        try
                        {
                             string b2 = Console.ReadLine();
                             z3 = double.Parse(b2);
                             break;
                        }
                        catch (SystemException)
                        {
                                Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                    }
                    double iloraz = z2 / z3;
                    Console.WriteLine("iloraz wynosi: {0}", iloraz);
                    
                    break;



            }




            Console.ReadKey();






        }
    }
}
