using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjątki
{
    class Program
    {
        static void Main(string[] args)
        {
            //obsługa wyjątków
            uint number;
            while (true)
                {
                Console.WriteLine("wprowadz liczbę całkowitą: ");
                string x = Console.ReadLine();
                try
                    {
                        
                        number = uint.Parse(x);
                    break;

                    }
                    catch (SystemException e)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Podałeś błędne dane: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(x);
                    
                    }

                }
           
            Console.WriteLine("Prawidłowe dane: {0},", number);
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.ReadKey();

        }
    }
}
