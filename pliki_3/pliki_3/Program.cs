using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace pliki_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo wsbDir = new DirectoryInfo(".");
            Console.WriteLine(wsbDir.FullName);

            //DirectoryInfo studentDir = new DirectoryInfo("C:\Users\Student\Desktop");

            DirectoryInfo studentDir = new DirectoryInfo(@"C:\Users\Student");
            //ścieżka
            Console.WriteLine(studentDir.FullName);
            //nazwa folderu
            Console.WriteLine(studentDir.Name);
            //folder nadrzędny 
            Console.WriteLine(studentDir.Parent);
            //właściwości
            Console.WriteLine(studentDir.Attributes);
            //kiedy stworzony
            Console.WriteLine(studentDir.CreationTime);

            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\Student\C#Files");

            string[] clients =
            {
                "Agnieszka Nowak",
                "Anna Nowak",
                "Tomasz Kowalski",
            };
            //tworzenie pliku 1


            string path = @"C:\Users\student\C#Files";
            //instrukcja warukowa tworzenia pliku jeżeli nie istnieje
            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Katalog istnieje");
                }
                else
                {
                    string textFilePath = @"C:\Users\student\C#Files\testFile1.txt";
                    Directory.CreateDirectory("\\users\\student\\C#Files");
                    //dodawanie do pliku
                    File.WriteAllLines(textFilePath, clients);
                    Console.WriteLine("\nutworzono katalog: {0}", Directory.GetCreationTime(path));


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("error: {0}", e.ToString());
            }
            //Czy chcesz usunąć katalog 1-true  0-false, 1 - sprawdzamy czy usunięty 0 - nie usunałeś katalogu


            DirectoryInfo myDataDir = new DirectoryInfo(path);

            Console.WriteLine();

            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Ilość plików txt: {0}",txtFiles.Length);

            Console.WriteLine("Pliki tekstowe");

            foreach (FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }




            Console.ReadKey();
        }
    }
}
