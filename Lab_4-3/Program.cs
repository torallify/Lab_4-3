using System;

namespace Lab_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumbers.MakePrimeList();

            Console.WriteLine("Let's locate some primes!");

            Console.WriteLine("This application will find you any prime, in order, from first prime number on.");

            do
            {
                Console.Write("\nWhich prime number are you looking for? ");
                var userInput = int.Parse(Console.ReadLine());

                Console.WriteLine($"The number {userInput} prime is {PrimeNumbers.GetPrime(userInput)}");

            } while (UserContinue());
        }
        static bool UserContinue()
        {
            char key;
            do
            {
                Console.Write("\nDo you want to find another prime number? (y/n): ");
                key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);
                if (key == 'n')
                {
                    return false;
                }
                Console.WriteLine();

            } while (key != 'y');
            return true;
        }
    }
}
