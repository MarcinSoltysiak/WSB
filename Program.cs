using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("wybierz jedną z opcji \n 1 \n 2");
        int name = int.Parse(Console.ReadLine()); ;
        switch (name)
        {
            case 1:
                Console.WriteLine(1);
                goto case 2;
            case 2:
                Console.WriteLine("stało się x \n wybierz: \n 1 \n 2"); //drugi wybór
                
        {
                    int nam = int.Parse(Console.ReadLine()); ;
                    switch (nam)
                    {
                        case 1:
                            Console.WriteLine("stało się y");
                            break;




                    }




                }
            case 3:
                Console.WriteLine(2);
                goto case 4;
            case 4:
                Console.WriteLine("stało się x");
                break;
            


        }
    }
}