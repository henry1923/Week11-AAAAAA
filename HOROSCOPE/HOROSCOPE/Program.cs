using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your horoscope sign:");
            string userSign = Console.ReadLine();
            Console.WriteLine(GetHoroscope(userSign));



        }
        //a function to open and read the file
        public static string[] ReadHoroscope()
        {
            string filepath = @"C:\Users\opilane\samples\horoscope.txt"; //absolute file path
            string[] DataFromFile = File.ReadAllLines(filepath);
            Console.WriteLine(DataFromFile.Length);

            return DataFromFile;
        }

        public static string GetHoroscope(string userInput)
        {
            string[] horoscope = ReadHoroscope();
            string todayHoroscope = "";

            foreach (string element in horoscope)
            {
                if (element.Contains(userInput))
                {
                    todayHoroscope = element;
                }
            }

            return todayHoroscope;
        }




    }
}
