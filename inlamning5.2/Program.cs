using System;
using System.Threading.Channels;

namespace inlamning5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = new string[4];
            numbers[1] = "1997";
            numbers[2] = "72";

            Console.WriteLine("Skriv in valfritt heltal");
            numbers[3] = Console.ReadLine();

            Console.WriteLine($"{numbers[1]}, {numbers[2]}, {numbers[3]}");
            Console.ReadKey();

        }

    }

}