using System/;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISESTA OMA EESNIMI: ");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("SISESTA OMA PEREKONNANIMI.");
            string userLastName = Console.ReadLine();

            string fullName = $"{userFirstName}{userLastName}";

            int counter = 0;

            foreach(char character in fullName)
            {
                if (character == 'a') ;
            }   

            {

                counter++;
                    
            }

            Console.WriteLine($"sinu nimes on {counter} a-tähte");


        }
    }
}
