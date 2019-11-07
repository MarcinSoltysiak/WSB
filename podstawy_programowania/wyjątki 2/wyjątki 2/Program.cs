using System;

namespace wyjątki_2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while(true)
            {
                Console.WriteLine("Wprowadz liczbę całkowitą: ");
                string x = Console.ReadLine();
                try
                {
                    number = uint.Parse(x);
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Wprowadz liczbę w poprawnym formacie ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("wprowadz liczbę w dopuszcalnym zakresie");
                    Console.WriteLine("zakres liczb: <0;4 294967295>");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("wartość nie może być pusta");

                }
                Console.WriteLine("wprowadź poprawnie wartość: ");

            }
            Console.WriteLine("Poprawna wartość: {0}",number);





            //pobierz od użytkownika jakaś wartość od 1 do 5 

            Console.ReadKey();
        }
    }
}
