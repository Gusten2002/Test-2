using System;
using System.IO;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            // Console.WriteLine("Hello World!");

            // File.WriteAllText("Words.txt", "Thing");
            // String s = File.ReadAllText("words.txt");

            // Console.WriteLine(s);

            string [] words = {"Hat", "Coat", "Pants", "Gloves", "Cap"};

            File.WriteAllLines("words.txt", words);

            // if (File.Exists("words.txt"))
            // {
            words = File.ReadAllLines("words.txt");

            int randomnumber = generator.Next(0,5);

            Console.WriteLine(words[randomnumber]);

            // }
            Console.ReadLine();

        }
    }
}
