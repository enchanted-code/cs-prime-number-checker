using System;

namespace prime_number_checker
{
    class Program
    {
        static void Main(string[] _)
        {
            while (true)
            {
                Console.Write("Enter Int To Check Or (q)uit: ");
                string input = Console.ReadLine();
                if (input.StartsWith("q"))
                {
                    break;
                }
                bool valid = int.TryParse(input, out int number);
                if (!valid) {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                if (IsPrime(number))
                {
                    Console.WriteLine("Number Is Prime");
                }
                else
                {
                    Console.WriteLine("Number Is Not Prime");
                }

            }
        }
        /**
         * <summary>check whether number is a prime</summary>
         * <param name="number">int to check</param>
         */
        public static bool IsPrime(int number)
        {
            if (number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
