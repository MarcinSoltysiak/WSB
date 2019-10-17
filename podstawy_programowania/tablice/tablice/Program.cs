using System;

namespace tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //napisz program który 10 elementowej tablicy 1 wymiarowej o nazwie tab umieszcza liczby całkowite z przedziału 1 do 10


            int n = 10, i;

            //deklaracja tablicy o nazwie tab typu całkowietego o rozmiarze n = 10
            

            //wyświetlenie zawartości tablicy
            int[] tab = new int[n];

            for (i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("{0} ",tab[i]);
            }
            //napisz program który 5 elementowej tablicy 1 wymiarowej o nazwie colors umieszcza nazwy kolorów podane z klawiatury przez użytkownika, wyświetl kolory w formacie kolor1: red Kolor2: blue

        }
    }
}
