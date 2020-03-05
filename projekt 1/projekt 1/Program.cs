using System;
using System.Diagnostics;
namespace ProjektWzorcowy
{
    class Program
    {

        static void Main(string[] args)
        {
            const int NIter = 5; // liczba powtórzeń testu
            Console.WriteLine("n\tt[s]");
            
            for (uint u = 0; u < 268435456; u += 20000000)
            {
                double ElapsedSeconds;
                long ElapsedTime = 0, MinTime = long.MaxValue, MaxTime = long.MinValue, IterationElapsedTime;
                
                for (int n = 0; n < (NIter + 1 + 1); ++n) // odejmujemy wartości skrajne
                {
                    long StartingTime = Stopwatch.GetTimestamp();
                    //metoda
                    uint d = 0;
                    uint c = 0;
                    uint m = 256432567;
                    uint[] abc = new uint[m];
                    for (int a = 0; a < 256432567; a++)
                    {
                        
                        d++;
                        abc[c] = d;
                        c++;
                        for ()
                    }
                    foreach (uint item in abc)
                    {
                        Console.WriteLine(item); ;
                    }
                    //koniec metody
                    long EndingTime = Stopwatch.GetTimestamp();
                    IterationElapsedTime = EndingTime - StartingTime;
                    ElapsedTime += IterationElapsedTime;
                    //Console.Write("Iter[" + n + "]:" + IterationElapsedTime + "\t");
                    if (IterationElapsedTime < MinTime) MinTime = IterationElapsedTime;
                    if (IterationElapsedTime > MaxTime) MaxTime = IterationElapsedTime;
                }
                ElapsedTime -= (MinTime + MaxTime);
                ElapsedSeconds = ElapsedTime * (1.0 / (NIter * Stopwatch.Frequency));
                Console.WriteLine("{0}\t{1}", u, ElapsedSeconds.ToString("F4"));
            }
        }
        
    }
}
