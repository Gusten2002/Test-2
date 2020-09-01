using System;
using System.IO;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // File.WriteAllText("Words.txt", "Thing");
            // String s = File.ReadAllText("words.txt");

            // Console.WriteLine(s);

            // string [] words = {"Hat", "Coat", "Pants"};

            // File.WriteAllLines("words.txt", words);

            if (File.Exists("words.txt"))
            {
            string [] words = File.ReadAllLines("words.txt");

            Console.WriteLine(words[0]);

            Console.ReadLine();

            }

        }
    }
}
