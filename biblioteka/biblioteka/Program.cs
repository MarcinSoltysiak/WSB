using System;
using biblioteka_dll;

namespace biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathclass x = new Mathclass();
            Console.WriteLine(x.Add(3,5));
            Console.ReadKey();
        }
    }
}
