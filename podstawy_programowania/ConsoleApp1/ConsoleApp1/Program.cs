using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabliczka mnożenia");
            int n = 10, row, col;
            row = 1;
            do
            {
                col = 1;
                do
                {
                    Console.Write(row * col + "\t");
                    col++;
                } while (col <= n);
                row++;
                Console.WriteLine();
            } while (row <= n);

            
        //napisz program który wyświetli duże litery od a do z i z do a z wykorzystaniem pętli for np A, B, C,... Z.

            for (char A = 'A'; A <= 'Z';A++)
            {
                if (A != 'Z')
                    Console.Write("");
                else
                {
                    Console.Write(A + ".");
                }
                Console.Write(A);


            }
            for (char Z = 'Z'; Z >= 'A';Z-- )
            {
             if (Z != 'A')
                {

                }
            }

            //continue
            int j = 1;
            for (; j <= 10; j++)
            {
                if (j==2 || j == 5 || j == 7)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
            //break

            int j = 10;
            for (; j <= 10; j++)
            {
                if (j == 2 || j == 5 || j == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(j);
                }
            }



            Console.ReadKey();










        }
    } //napisz program który za pomocą instrukcji do...while dla danych wartości zmieniających się w przedziale od 0 do 15 oblicz wartość funkcji y=4x
    //napisz program zanjdujący się powyżej za pomocą pętli while

}
