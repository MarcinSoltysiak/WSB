using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struktury
{
    class Program
    {
        public struct Punkt
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt();

            punkt1.x = 5;
            punkt1.y = 15;

            Punkt punkt2;
            punkt2.x = 2;
            punkt2.y = 3;


            Console.WriteLine("x jest równe: {0} a y jest równe {1}",punkt1.x,punkt1.y);

            Console.WriteLine("x jest równe: {0} a y jest równe {1}", punkt2.x, punkt2.y);




            Console.ReadKey();
        }
    }
}
