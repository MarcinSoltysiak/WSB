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
                Console.WriteLine("x = {0}",x);
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
            

            switch (c)
            {
                case "1":
                    int z;
                    int z1;
                   Console.WriteLine("Podaj wartość a: ");
                     while(true)
                       {
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
                            Console.WriteLine("Podaj wartość b: ");
                            try
                            {
                            string b2 = Console.ReadLine();
                            z1 = int.Parse(b2);
                            }
                            catch (SystemException)
                            {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                            }
                            
                            Console.WriteLine("suma wynosi: {0}");
                        }
                    break;
                case "2":
                    Console.WriteLine("Podaj wartość a: ");
                    while (true)
                    {
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
                        int suma;
                        Console.WriteLine("suma wynosi: {0}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Podaj wartość a: ");
                    while (true)
                    {
                        try
                        {
                            string a2 = Console.ReadLine();
                            int z = int.Parse(a2);
                            
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                        Console.WriteLine("Podaj wartość b: ");
                        try
                        {
                            string b2 = Console.ReadLine();
                            z 1= int.Parse(b2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                        
                        Console.WriteLine("suma wynosi: {0}");
                    }
                    break;
                case "4":
                    Console.WriteLine("Podaj wartość a: ");
                    while (true)
                    {
                        try
                        {
                            string a2 = Console.ReadLine();
                            double z2 = double.Parse(a2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                        Console.WriteLine("Podaj wartość b: ");
                        try
                        {
                            string b2 = Console.ReadLine();
                            double z3 = double.Parse(b2);
                            break;
                        }
                        catch (SystemException)
                        {
                            Console.WriteLine("Podana warotść musi być cyfrą");
                        }
                        int suma;
                        Console.WriteLine("suma wynosi: {0}");
                    }
                    break;



            }
            
            


            Console.ReadKey();






        }
    }
}

